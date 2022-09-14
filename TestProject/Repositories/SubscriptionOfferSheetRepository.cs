using Microsoft.EntityFrameworkCore;
using TestProject.Entities;

namespace TestProject.Repositories
{
    public class SubscriptionOfferSheetRepository
    {
        public IQueryable<SubscriptionOfferSheet> GetAllSubscriptionOfferSheets()
        {
            return SubscriptionOfferSheets.Rows
                    .AsQueryable()
                    .AsNoTracking();
        }
    }
}
