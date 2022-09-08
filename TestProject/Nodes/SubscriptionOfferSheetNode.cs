using TestProject.DataLoaders;
using TestProject.Entities;
using TestProject.InputTypes;
using TestProject.Repositories;

namespace TestProject.Nodes
{
    [Node]
    [ExtendObjectType(typeof(SubscriptionOfferSheet))]
    public class SubscriptionOfferSheetNode
    {
        [UsePaging]
        //[UseFiltering(typeof(PromotionLineFilterInputType))]
        [UseFiltering(typeof(CommonFilterInputType<PromotionLine>))]
        [UseSorting]
        [BindMember(nameof(SubscriptionOfferSheet.PromotionLines), Replace = true)]
        public Task<IEnumerable<PromotionLine>> GetPromotionLinesAsync(
            [Parent] SubscriptionOfferSheet subscriptionOfferSheet,
            [Service] PromotionLineRepository promotionLineRepository,
            CancellationToken cancellationToken)
        {
            return promotionLineRepository.GetPromotionLinesBySubscriptionOfferSheetId(subscriptionOfferSheet.Id);
        }

        [NodeResolver]
        public async static Task<SubscriptionOfferSheet> GetSubscriptionOfferSheetByIdAsync(
            Guid id,
            [Service] SubscriptionOfferSheetByIdDataLoader dataLoader,
            CancellationToken cancellationToken)
        {
            return await dataLoader.LoadAsync(id, cancellationToken);
        }
    }
}
