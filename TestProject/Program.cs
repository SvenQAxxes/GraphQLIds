using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Voyager;
using Microsoft.EntityFrameworkCore;
using TestProject;
using TestProject.DataLoaders;
using TestProject.Nodes;
using TestProject.Queries;
using TestProject.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddPooledDbContextFactory<TestDbContext>(options 
    => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestCatalog;Integrated Security=True;"));

builder.Services.AddTransient(_ => new SubscriptionOfferSheetRepository(_.GetRequiredService<IDbContextFactory<TestDbContext>>().CreateDbContext()));
builder.Services.AddTransient(_ => new PromotionLineRepository(_.GetRequiredService<IDbContextFactory<TestDbContext>>().CreateDbContext()));

builder.Services
    .AddMemoryCache()
    .AddGraphQLServerCore()
    .AddGraphQL()
    .AddHttpRequestInterceptor<DefaultHttpRequestInterceptor>()
    .AddQueryType()
        .AddTypeExtension<PromotionLineQueries>()
        .AddTypeExtension<SubscriptionOfferSheetQueries>()
        .AddTypeExtension<SubscriptionOfferSheetNode>()
        .AddTypeExtension<PromotionLineNode>()
    .AddDataLoader<SubscriptionOfferSheetByIdDataLoader>()
    .AddDataLoader<PromotionLineByIdDataLoader>()
    .AddFiltering()
    .AddSorting()
    .AddGlobalObjectIdentification();

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
