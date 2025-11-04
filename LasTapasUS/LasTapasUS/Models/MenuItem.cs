namespace LasTapasUS.Models
{
    public enum Allergen
    {
        Gluten,
        Lactose,
        Nuts,
        Shellfish,
        Eggs,
        Fish,
        Soy
    }
    public class MenuItem
    {
        public string Category { get; set; } = "";
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; }

        public List<Allergen> Allergens { get; set; } = new();
        public required string ImagePath { get; set; }
    }
}
