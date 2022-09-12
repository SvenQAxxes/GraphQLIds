using Microsoft.EntityFrameworkCore;
using TestProject.Entities;

namespace TestProject.Repositories
{
    public class PromotionLineRepository
    {
        private readonly ICollection<PromotionLine> _lines = new List<PromotionLine>
        {
            new PromotionLine
                {
                    Id = Guid.NewGuid(),
                    Code = RandomValues.RandomString(10),
                    ConditionDescription = RandomValues.RandomString(25),
                    Country = RandomValues.RandomString(10),
                    Created = RandomValues.RandomDay(),
                    Name = RandomValues.RandomString(25),
                    SubscriptionOfferSheetId = new Guid("df160c11-4691-4a2f-b84d-1f4adfc92c21"),
                    PriorityWeight = 1
                },
                new PromotionLine
                {
                    Id = Guid.NewGuid(),
                    Code = RandomValues.RandomString(10),
                    ConditionDescription = RandomValues.RandomString(25),
                    Country = RandomValues.RandomString(10),
                    Created = RandomValues.RandomDay(),
                    Name = RandomValues.RandomString(25),
                    SubscriptionOfferSheetId = new Guid("df160c11-4691-4a2f-b84d-1f4adfc92c21"),
                    PriorityWeight = 1
                },
                new PromotionLine
                {
                    Id = Guid.NewGuid(),
                    Code = RandomValues.RandomString(10),
                    ConditionDescription = RandomValues.RandomString(25),
                    Country = RandomValues.RandomString(10),
                    Created = RandomValues.RandomDay(),
                    Name = RandomValues.RandomString(25),
                    SubscriptionOfferSheetId = new Guid("f842222f-24f3-4fd3-ac48-ded7aca308e1"),
                    PriorityWeight = 1
                },
                new PromotionLine
                {
                    Id = Guid.NewGuid(),
                    Code = RandomValues.RandomString(10),
                    ConditionDescription = RandomValues.RandomString(25),
                    Country = RandomValues.RandomString(10),
                    Created = RandomValues.RandomDay(),
                    Name = RandomValues.RandomString(25),
                    SubscriptionOfferSheetId = new Guid("df160c11-4691-4a2f-b84d-1f4adfc92c21"),
                    PriorityWeight = 1
                },
                new PromotionLine
                {
                    Id = Guid.NewGuid(),
                    Code = RandomValues.RandomString(10),
                    ConditionDescription = RandomValues.RandomString(25),
                    Country = RandomValues.RandomString(10),
                    Created = RandomValues.RandomDay(),
                    Name = RandomValues.RandomString(25),
                    SubscriptionOfferSheetId = new Guid("f842222f-24f3-4fd3-ac48-ded7aca308e1"),
                    PriorityWeight = 1
                }
        };

        public async Task<IEnumerable<PromotionLine>> GetPromotionLinesBySubscriptionOfferSheetId(Guid id)
        {
            return await Task.FromResult(_lines
                .Where(pl => pl.SubscriptionOfferSheetId == id)
                .ToList());
        }

        internal IQueryable<PromotionLine> GetAllPromotionLines()
        {
            return _lines
                .AsQueryable()
                .AsNoTracking();
        }
    }
}
