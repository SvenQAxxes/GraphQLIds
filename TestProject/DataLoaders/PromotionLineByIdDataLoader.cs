using Microsoft.EntityFrameworkCore;
using TestProject.Entities;
using TestProject.Repositories;

namespace TestProject.DataLoaders
{
    public class PromotionLineByIdDataLoader : BatchDataLoader<Guid, PromotionLine>
    {
        public PromotionLineByIdDataLoader(
            IBatchScheduler batchScheduler,
            DataLoaderOptions options)
            : base(batchScheduler, options)
        {
        }

        protected override async Task<IReadOnlyDictionary<Guid, PromotionLine>> LoadBatchAsync(
            IReadOnlyList<Guid> keys,
            CancellationToken cancellationToken)
        {
            return PromotionLines.Rows
                .Where(s => keys.Contains(s.Id))
                .ToDictionary(t => t.Id);
        }
    }
}
