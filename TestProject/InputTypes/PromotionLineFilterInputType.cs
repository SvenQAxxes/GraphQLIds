using HotChocolate.Data.Filters;
using TestProject.Entities;

namespace TestProject.InputTypes
{
    public class PromotionLineFilterInputType : FilterInputType<PromotionLine>
    {
        protected override void Configure(IFilterInputTypeDescriptor<PromotionLine> descriptor)
        {
            descriptor.Field(y => y.Id).Type<IdOperationFilterInputType>();
        }
    }
}
