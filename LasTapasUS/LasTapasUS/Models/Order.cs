namespace LasTapasUS.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsPaid { get; set; } = false;
        public List<OrderItem> Items { get; set; } = new();
    }
}
