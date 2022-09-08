using TestProject.Entities;
using TestProject.InputTypes;
using TestProject.Repositories;

namespace TestProject.Queries
{
    [ExtendObjectType(OperationTypeNames.Query)]
    public class PromotionLineQueries
    {
        [UsePaging]
        [UseFiltering(typeof(CommonFilterInputType<PromotionLine>))]
        //[UseFiltering(typeof(PromotionLineFilterInputType))]
        [UseSorting]
        public async Task<IQueryable<PromotionLine>> GetPromotionLinesAsync(
        [Service] PromotionLineRepository promotionLineRepository,
        CancellationToken cancellationToken)
        {
            return promotionLineRepository.GetAllPromotionLines();
        }
    }
}
