using Microsoft.EntityFrameworkCore;
using TestProject.Entities;

namespace TestProject.DataLoaders
{
    public class PromotionLineByIdDataLoader : BatchDataLoader<Guid, PromotionLine>
    {
        private readonly IDbContextFactory<TestDbContext> _dbContextFactory;

        public PromotionLineByIdDataLoader(
            IDbContextFactory<TestDbContext> dbContextFactory,
            IBatchScheduler batchScheduler,
            DataLoaderOptions options)
            : base(batchScheduler, options)
        {
            _dbContextFactory = dbContextFactory ??
                                throw new ArgumentNullException(nameof(dbContextFactory));
        }

        protected override async Task<IReadOnlyDictionary<Guid, PromotionLine>> LoadBatchAsync(
            IReadOnlyList<Guid> keys,
            CancellationToken cancellationToken)
        {
            await using var dbContext =
                await _dbContextFactory.CreateDbContextAsync(cancellationToken);

            return await dbContext.PromotionLines
                .Where(s => keys.Contains(s.Id))
                .ToDictionaryAsync(t => t.Id, cancellationToken);
        }
    }
}
