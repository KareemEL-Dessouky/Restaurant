using Microsoft.EntityFrameworkCore;

using Restaurant.Helper;
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

            builder.Services.AddScoped<IGenericRepository<Product>, ProductRepository>();
            builder.Services.AddScoped<IGenericRepository<Customer>, CustomerRepository>();
            builder.Services.AddScoped<IGenericRepository<Category>, CategoryRepository>();
            builder.Services.AddScoped<IGenericRepository<Order>, OrderRepository>();
            builder.Services.AddScoped<IGenericRepository<OrderItems>, OrderItemsRepository>();

            // configure and inject automapper

            var config = new AutoMapper.MapperConfiguration(config =>
            {
                config.AddProfile(new AutomapperProfile());

            });
            var mapper = config.CreateMapper();

            builder.Services.AddSingleton(mapper);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}