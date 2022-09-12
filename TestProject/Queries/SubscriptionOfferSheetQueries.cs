using TestProject.Entities;
using TestProject.InputTypes;
using TestProject.Repositories;

namespace TestProject.Queries
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class SubscriptionOfferSheetQueries
    {
        [UsePaging]
        //[UseFiltering(typeof(SubscriptionOfferSheetFilterInputType))]
        [UseFiltering(typeof(CommonFilterInputType<SubscriptionOfferSheet>))]
        [UseSorting]
        public async Task<IQueryable<SubscriptionOfferSheet>> GetSubscriptionOfferSheetAsync(
            [Service] SubscriptionOfferSheetRepository subscriptionOfferSheetRepository,
            CancellationToken cancellationToken)
        {
            var result = subscriptionOfferSheetRepository.GetAllSubscriptionOfferSheets();
            return result;
        }
    }
}
