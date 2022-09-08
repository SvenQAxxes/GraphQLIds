using System.ComponentModel.DataAnnotations;

namespace TestProject.Entities
{
    public class EntityBase
    {
        [Key]
        public Guid Id { get; set; }

        [GraphQLIgnore]
        public DateTimeOffset Created { get; set; }

        [GraphQLIgnore]
        public DateTimeOffset LastUpdated { get; set; }
    }
}
