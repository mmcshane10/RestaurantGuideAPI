using Microsoft.EntityFrameworkCore;

namespace RestaurantGuide.Models
{
    public class RestaurantGuideContext : DbContext
    {
        public RestaurantGuideContext(DbContextOptions<RestaurantGuideContext> options)
            : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Restaurant>()
                .HasData(
                    new Restaurant { RestaurantId = 1, Name = "Eem", Cuisine = "Thai BBQ", Address = "123 Fake St", Neighborhood = "Boise", Quadrant = "NE" },

                    new Restaurant { RestaurantId = 2, Name = "Ken's Artisan Pizza", Cuisine = "Pizza", Address = "124 Fake St.", Neighborhood = "Kerns", Quadrant = "SE" },

                    new Restaurant { RestaurantId = 3, Name = "Serratto", Cuisine = "Italian", Address = "125 Fake St.", Neighborhood = "Nob Hill", Quadrant = "NW" }
                );
        }
    }
}