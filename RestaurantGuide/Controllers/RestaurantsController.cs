using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantGuide.Models;

namespace RestaurantGuide.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private RestaurantGuideContext _db;

        public RestaurantsController(RestaurantGuideContext db)
        {
            _db = db;
        }

        // GET api/restaurants
        [HttpGet]
        public ActionResult<IEnumerable<Restaurant>> Get(string name, string cuisine, string neighborhood, string quadrant)
        {
            var query = _db.Restaurants.AsQueryable();

            if (name != null)
            {
                query = query.Where(entry => entry.Name.Contains(name));
            }

            if (cuisine != null)
            {
                query = query.Where(entry => entry.Cuisine.Contains(cuisine));
            }

            if (neighborhood != null)
            {
                query = query.Where(entry => entry.Neighborhood.Contains(neighborhood));
            }

            if (quadrant != null)
            {
                query = query.Where(entry => entry.Quadrant.Contains(quadrant));
            }

            return query.ToList();
        }

        // POST api/restaurants
        [HttpPost]
        public void Post([FromBody] Restaurant restaurant)
        {
            _db.Restaurants.Add(restaurant);
            _db.SaveChanges();
        }

        // GET api/restaurants/5
        [HttpGet("{id}")]
        public ActionResult<Restaurant> Get(int id)
        {
            return _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
        }

        // PUT api/restaurants/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Restaurant restaurant)
        {
            restaurant.RestaurantId = id;
            _db.Entry(restaurant).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/restaurants/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var restaurantToDelete = _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
            _db.Restaurants.Remove(restaurantToDelete);
            _db.SaveChanges();
        }
    }
}