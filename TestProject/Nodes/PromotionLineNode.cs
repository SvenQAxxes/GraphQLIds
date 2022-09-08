using TestProject.DataLoaders;
using TestProject.Entities;
using TestProject.InputTypes;

namespace TestProject.Nodes
{
    [Node]
    [ExtendObjectType(typeof(PromotionLine))]
    public class PromotionLineNode
    {
        [NodeResolver]
        public async static Task<PromotionLine> GetPromotionLineByIdAsync(
            Guid id,
            [Service] PromotionLineByIdDataLoader dataLoader,
            CancellationToken cancellationToken)
        {
            return await dataLoader.LoadAsync(id, cancellationToken);
        }
    }
}
