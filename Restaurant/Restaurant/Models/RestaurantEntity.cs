using Microsoft.EntityFrameworkCore;

namespace Restaurant.Models
{
    public class RestaurantEntity : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> CustomerOrders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public RestaurantEntity(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItems>()
                .HasKey(k => new { k.OrderID, k.ProductID });
        }
    }
}
