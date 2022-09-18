namespace CQRSWithMediator.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Items { get; set; }
        public decimal quantity { get; set; }
    }
}
