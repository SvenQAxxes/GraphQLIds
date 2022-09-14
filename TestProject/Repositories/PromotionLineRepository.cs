using Microsoft.EntityFrameworkCore;
using TestProject.Entities;

namespace TestProject.Repositories
{
    public class PromotionLineRepository
    {
        public async Task<IEnumerable<PromotionLine>> GetPromotionLinesBySubscriptionOfferSheetId(Guid id)
        {
            return await Task.FromResult(PromotionLines.Rows
                .Where(pl => pl.SubscriptionOfferSheetId == id)
                .ToList());
        }

        internal IQueryable<PromotionLine> GetAllPromotionLines()
        {
            return PromotionLines.Rows
                .AsQueryable()
                .AsNoTracking();
        }
    }
}
