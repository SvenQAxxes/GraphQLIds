using Microsoft.EntityFrameworkCore;
using TestProject.Entities;
using TestProject.Repositories;

namespace TestProject.DataLoaders
{
    public class SubscriptionOfferSheetByIdDataLoader : BatchDataLoader<Guid, SubscriptionOfferSheet>
    {
        public SubscriptionOfferSheetByIdDataLoader(
            IBatchScheduler batchScheduler,
            DataLoaderOptions options)
            : base(batchScheduler, options)
        {
        }

        protected override async Task<IReadOnlyDictionary<Guid, SubscriptionOfferSheet>> LoadBatchAsync(
            IReadOnlyList<Guid> keys,
            CancellationToken cancellationToken)
        {
            return SubscriptionOfferSheets.Rows
                .Where(s => keys.Contains(s.Id))
                .ToDictionary(t => t.Id);
        }
    }
}
