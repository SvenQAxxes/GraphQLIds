using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Voyager;
using Microsoft.EntityFrameworkCore;
using TestProject;
using TestProject.DataLoaders;
using TestProject.Nodes;
using TestProject.Queries;
using TestProject.Repositories;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddPooledDbContextFactory<TestDbContext>(options 
    => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestCatalog;Integrated Security=True;"));

builder.Services.AddTransient<SubscriptionOfferSheetRepository>();
builder.Services.AddTransient<PromotionLineRepository>();

builder.Services
    .AddMemoryCache()
    .AddGraphQLServerCore()
    .AddGraphQL()
    .AddQueryType()
        .AddTypeExtension<PromotionLineQueries>()
        .AddTypeExtension<SubscriptionOfferSheetQueries>()
        .AddTypeExtension<SubscriptionOfferSheetNode>()
        .AddTypeExtension<PromotionLineNode>()
    .AddDataLoader<SubscriptionOfferSheetByIdDataLoader>()
    .AddDataLoader<PromotionLineByIdDataLoader>()
    .AddFiltering()
    .AddSorting()
    .AddGlobalObjectIdentification()
    .AddHttpRequestInterceptor<DefaultHttpRequestInterceptor>()
    .AddIdSerializer(true)
    .PublishSchemaDefinition(c => c
                    .SetName("testschema")
                    .IgnoreRootTypes()
                    .AddTypeExtensionsFromFile("./Stitching.graphql")); ;

//builder.Services.RemoveAll<IIdSerializer>();
//builder.Services.AddSingleton<IIdSerializer>(new IdSerializer(includeSchemaName: true));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints
        .MapGraphQL();

    app.UseVoyager("/graphql", "/graphql-voyager");

    endpoints.MapGet("/", context =>
    {
        context.Response.Redirect("/graphql", true);
        return Task.CompletedTask;
    });
});

app.UseHttpsRedirection();

app.Run();
