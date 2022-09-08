using Microsoft.EntityFrameworkCore;
using TestProject.Entities;

namespace TestProject.Repositories
{
    public class PromotionLineRepository
    {
        private readonly TestDbContext _context;

        public PromotionLineRepository(TestDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<PromotionLine>> GetPromotionLinesBySubscriptionOfferSheetId(Guid id)
        {
            return await _context.PromotionLines
                .Where(pl => pl.SubscriptionOfferSheetId == id)
                .ToListAsync();
        }

        internal IQueryable<PromotionLine> GetAllPromotionLines()
        {
            return _context.PromotionLines
                .AsQueryable()
                .AsNoTracking();
        }
    }
}
