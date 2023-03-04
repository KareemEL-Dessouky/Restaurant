using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Restaurant.Data;

namespace Restaurant.Models
{
    public class RestaurantContext : IdentityDbContext<ApplicationUser> //DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> CustomerOrders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<OrderItems> OrderItems { get; set; }

        public RestaurantContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItems>()
                .HasKey(k => new { k.OrderID, k.ProductID });

            // seed dummy data
            modelBuilder.Seed();
        }
    }
}
