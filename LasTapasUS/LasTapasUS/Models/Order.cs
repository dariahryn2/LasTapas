namespace LasTapasUS.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Table { get; set; } = "";
        public string Dish { get; set; } = "";
        public string Status { get; set; } = "Pending"; // Pending, Prepared, Served
    }
}
