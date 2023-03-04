using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Restaurant.Models;
using Restaurant.Repositories;

namespace Restaurant
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<RestaurantContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("Cs"))
                );
            // add identity service to work on users & admins, and declare which store you used
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options=>
            {
                options.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<RestaurantContext>();

            builder.Services.AddScoped<IGenericRepository<Product>, ProductRepository>();
            builder.Services.AddScoped<IGenericRepository<Customer>, CustomerRepository>();
            builder.Services.AddScoped<IGenericRepository<Category>, CategoryRepository>();
            builder.Services.AddScoped<IGenericRepository<Order>, OrderRepository>();
            builder.Services.AddScoped<IGenericRepository<OrderItems>, OrderItemsRepository>();

            // configure and inject automapper
            builder.Services.AddAutoMapper(typeof(Program));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();  // have valid account 
            app.UseAuthorization();  // all users allow permission

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
