using Microsoft.EntityFrameworkCore;
using TestProject.Entities;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TestProject
{
    public class TestDbContext : DbContext
    {
        public DbSet<SubscriptionOfferSheet> SubscriptionOfferSheets { get; set; }

        public DbSet<PromotionLine> PromotionLines { get; set; }

        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var sosId1 = Guid.NewGuid();
            var sosId2 = Guid.NewGuid();
            modelBuilder.Entity<SubscriptionOfferSheet>().HasData(
                new SubscriptionOfferSheet
                {
                    Id = sosId1,
                    Country = RandomValues.RandomString(10),
                    Created = RandomValues.RandomDay(),
                    CreationDate = RandomValues.RandomDay(),
                    Description = RandomValues.RandomString(25),
                    PublishDate = RandomValues.RandomDay()
                },
                new SubscriptionOfferSheet
                {
                    Id = sosId2,
                    Country = RandomValues.RandomString(10),
                    Created = RandomValues.RandomDay(),
                    CreationDate = RandomValues.RandomDay(),
                    Description = RandomValues.RandomString(25),
                    PublishDate = RandomValues.RandomDay()
                });

            var plId1 = Guid.NewGuid();
            var plId2 = Guid.NewGuid();
            var plId3 = Guid.NewGuid();
            var plId4 = Guid.NewGuid();
            var plId5 = Guid.NewGuid();
            modelBuilder.Entity<PromotionLine>().HasData(
                new PromotionLine
                {
                    Id = plId1,
                    Code = RandomValues.RandomString(10),
                    ConditionDescription = RandomValues.RandomString(25),
                    Country = RandomValues.RandomString(10),
                    Created = RandomValues.RandomDay(),
                    Name = RandomValues.RandomString(25),
                    SubscriptionOfferSheetId = sosId1,
                    PriorityWeight = 1
                },
                new PromotionLine
                {
                    Id = plId2,
                    Code = RandomValues.RandomString(10),
                    ConditionDescription = RandomValues.RandomString(25),
                    Country = RandomValues.RandomString(10),
                    Created = RandomValues.RandomDay(),
                    Name = RandomValues.RandomString(25),
                    SubscriptionOfferSheetId = sosId1,
                    PriorityWeight = 1
                },
                new PromotionLine
                {
                    Id = plId3,
                    Code = RandomValues.RandomString(10),
                    ConditionDescription = RandomValues.RandomString(25),
                    Country = RandomValues.RandomString(10),
                    Created = RandomValues.RandomDay(),
                    Name = RandomValues.RandomString(25),
                    SubscriptionOfferSheetId = sosId2,
                    PriorityWeight = 1
                },
                new PromotionLine
                {
                    Id = plId4,
                    Code = RandomValues.RandomString(10),
                    ConditionDescription = RandomValues.RandomString(25),
                    Country = RandomValues.RandomString(10),
                    Created = RandomValues.RandomDay(),
                    Name = RandomValues.RandomString(25),
                    SubscriptionOfferSheetId = sosId1,
                    PriorityWeight = 1
                },
                new PromotionLine
                {
                    Id = plId5,
                    Code = RandomValues.RandomString(10),
                    ConditionDescription = RandomValues.RandomString(25),
                    Country = RandomValues.RandomString(10),
                    Created = RandomValues.RandomDay(),
                    Name = RandomValues.RandomString(25),
                    SubscriptionOfferSheetId = sosId2,
                    PriorityWeight = 1
                });
        }
    }
}
