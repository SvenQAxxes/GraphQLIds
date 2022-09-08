using HotChocolate.Data.Filters;
using TestProject.Entities;

namespace TestProject.InputTypes
{
    public class CommonFilterInputType<T> : FilterInputType<T> where T : EntityBase
    {
        protected override void Configure(IFilterInputTypeDescriptor<T> descriptor)
        {
            descriptor.Field(y => y.Id).Type<IdOperationFilterInputType>();
        }
    }
}
