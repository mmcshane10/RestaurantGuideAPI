using System.ComponentModel.DataAnnotations;

namespace RestaurantGuide.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Cuisine { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Neighborhood { get; set; }
        [Required]
        public string Quadrant { get; set; }
    }
}