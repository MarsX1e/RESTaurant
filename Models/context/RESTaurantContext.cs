using Microsoft.EntityFrameworkCore;

namespace RESTaurant.Models
{
    public class RESTaurantContext: DbContext
    {
        public RESTaurantContext(DbContextOptions<RESTaurantContext> options) : base(options) {}
        public DbSet<Review> review { get; set; }
    }
}