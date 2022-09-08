namespace TestProject.Entities
{
    public class SubscriptionOfferSheet : EntityBase
    {
        public string Description { get; set; } = string.Empty;

        public DateTimeOffset CreationDate { get; set; }

        public DateTimeOffset PublishDate { get; set; }

        public string Country { get; set; } = string.Empty;

        public ICollection<PromotionLine> PromotionLines { get; set; } = new List<PromotionLine>();
    }
}
