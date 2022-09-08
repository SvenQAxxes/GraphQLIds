using Microsoft.EntityFrameworkCore;
using TestProject.Entities;

namespace TestProject.Repositories
{
    public class SubscriptionOfferSheetRepository
    {
        private readonly TestDbContext _context;

        public SubscriptionOfferSheetRepository(TestDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IQueryable<SubscriptionOfferSheet> GetAllSubscriptionOfferSheets()
        {
            return _context.SubscriptionOfferSheets
                    .AsQueryable()
                    .AsNoTracking();
        }
    }
}
