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
                    new Restaurant { RestaurantId = 1, Name = "Eem", Cuisine = "Thai BBQ", Address = "3808 N Williams Ave st 127, Portland, OR 97227", Neighborhood = "Boise", Quadrant = "NE" },

                    new Restaurant { RestaurantId = 2, Name = "Ken's Artisan Pizza", Cuisine = "Pizza", Address = "304 SE 28th Ave, Portland, OR 97214", Neighborhood = "Kerns", Quadrant = "SE" },

                    new Restaurant { RestaurantId = 3, Name = "Serratto", Cuisine = "Italian", Address = "2112 NW Kearney St, Portland, OR 97210", Neighborhood = "Nob Hill", Quadrant = "NW" },

                    new Restaurant { RestaurantId = 4, Name = "Marukin", Cuisine = "Japanese", Address = "609 SE Ankeny St A, Portland, OR 97214", Neighborhood = "Buckman", Quadrant = "SE" },

                    new Restaurant { RestaurantId = 5, Name = "Bullard", Cuisine = "American", Address = "813 SW Alder St, Portland, OR 97205", Neighborhood = "Downtown", Quadrant = "SW" },

                    new Restaurant { RestaurantId = 6, Name = "Guero", Cuisine = "Mexican", Address = "200 NE 28th Ave, Portland, OR 97232", Neighborhood = "Kerns", Quadrant = "NE" },

                    new Restaurant { RestaurantId = 7, Name = "La Luna Cafe", Cuisine = "Breakfast", Address = "828 SE Ash St, Portland, OR 97214", Neighborhood = "Buckman", Quadrant = "SE" },

                    new Restaurant { RestaurantId = 8, Name = "Nostrana", Cuisine = "Italian", Address = "1401 SE Morrison St Ste. 101, Portland, OR 97214", Neighborhood = "Buckman", Quadrant = "SE" },

                    new Restaurant { RestaurantId = 9, Name = "Revelry", Cuisine = "Korean", Address = "210 SE Martin Luther King Jr Blvd, Portland, OR 97214", Neighborhood = "Buckman", Quadrant = "NW" },

                    new Restaurant { RestaurantId = 10, Name = "XLB", Cuisine = "Chinese", Address = "4090 N Williams Ave, Portland, OR 97227", Neighborhood = "Nob Hill", Quadrant = "NE" }
                );
        }
    }
}