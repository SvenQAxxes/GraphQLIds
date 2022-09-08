using Microsoft.EntityFrameworkCore;
using TestProject.Entities;

namespace TestProject.DataLoaders
{
    public class SubscriptionOfferSheetByIdDataLoader : BatchDataLoader<Guid, SubscriptionOfferSheet>
    {
        private readonly IDbContextFactory<TestDbContext> _dbContextFactory;

        public SubscriptionOfferSheetByIdDataLoader(
            IDbContextFactory<TestDbContext> dbContextFactory,
            IBatchScheduler batchScheduler,
            DataLoaderOptions options)
            : base(batchScheduler, options)
        {
            _dbContextFactory = dbContextFactory ??
                                throw new ArgumentNullException(nameof(dbContextFactory));
        }

        protected override async Task<IReadOnlyDictionary<Guid, SubscriptionOfferSheet>> LoadBatchAsync(
            IReadOnlyList<Guid> keys,
            CancellationToken cancellationToken)
        {
            await using var dbContext =
                await _dbContextFactory.CreateDbContextAsync(cancellationToken);

            return await dbContext.SubscriptionOfferSheets
                .Where(s => keys.Contains(s.Id))
                .ToDictionaryAsync(t => t.Id, cancellationToken);
        }
    }
}
