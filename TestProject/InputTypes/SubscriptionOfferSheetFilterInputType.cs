using HotChocolate.Data.Filters;
using TestProject.Entities;

namespace TestProject.InputTypes
{
    public class SubscriptionOfferSheetFilterInputType : FilterInputType<SubscriptionOfferSheet>
    {
        protected override void Configure(IFilterInputTypeDescriptor<SubscriptionOfferSheet> descriptor)
        {
            descriptor.Field(y => y.Id).Type<IdOperationFilterInputType>();
        }
    }
}
