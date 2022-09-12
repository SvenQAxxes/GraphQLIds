using Microsoft.EntityFrameworkCore;
using TestProject.Entities;

namespace TestProject.Repositories
{
    public class SubscriptionOfferSheetRepository
    {
        private readonly ICollection<SubscriptionOfferSheet> _subscriptionOfferSheets = new List<SubscriptionOfferSheet>()
        {
            new SubscriptionOfferSheet
                {
                    Id = new Guid("df160c11-4691-4a2f-b84d-1f4adfc92c21"),
                    Country = RandomValues.RandomString(10),
                    Created = RandomValues.RandomDay(),
                    CreationDate = RandomValues.RandomDay(),
                    Description = RandomValues.RandomString(25),
                    PublishDate = RandomValues.RandomDay()
                },
                new SubscriptionOfferSheet
                {
                    Id = new Guid("f842222f-24f3-4fd3-ac48-ded7aca308e1"),
                    Country = RandomValues.RandomString(10),
                    Created = RandomValues.RandomDay(),
                    CreationDate = RandomValues.RandomDay(),
                    Description = RandomValues.RandomString(25),
                    PublishDate = RandomValues.RandomDay()
                }
        };

        public IQueryable<SubscriptionOfferSheet> GetAllSubscriptionOfferSheets()
        {
            return _subscriptionOfferSheets
                    .AsQueryable()
                    .AsNoTracking();
        }
    }
}
