namespace RestaurantGuide.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Cuisine { get; set; }
        public string Address { get; set; }
        public string Neighborhood { get; set; }
        public string Quadrant { get; set; }
    }
}