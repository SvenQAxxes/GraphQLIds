namespace TestProject.Entities
{
    public class PromotionLine : EntityBase
    {
        public string Name { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public string ConditionDescription { get; set; } = string.Empty;

        public int? PriorityWeight { get; set; }

        public string Country { get; set; } = string.Empty;

        public Guid SubscriptionOfferSheetId { get; set; }

        public Guid OfferId { get; set; }

        public Guid SeniorityId { get; set; }
    }
}
