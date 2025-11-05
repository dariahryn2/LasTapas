using Microsoft.EntityFrameworkCore;
using LasTapasUS.Models;

namespace LasTapasUS.Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; } = default!;
    }
}
