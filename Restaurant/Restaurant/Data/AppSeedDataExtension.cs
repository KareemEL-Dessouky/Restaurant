using Microsoft.EntityFrameworkCore;

using Restaurant.Models;

namespace Restaurant.Data;
// Dummy Data for testing

public static class AppSeedDataExtension
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(

            new Product
            {
                ID = 1,
                CategoryID = 1,
                Title = "Chicken Pizza",
                Price = 20,
                Image = "https://images.unsplash.com/photo-1615719413546-198b25453f85?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=736&q=80"
            },
            new Product
            {
                ID = 2,
                CategoryID = 1,
                Title = "Shrimp Meal",
                Price = 250,
                Image = "https://images.unsplash.com/photo-1619221882220-947b3d3c8861?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"
            },
            new Product
            {
                ID = 3,
                CategoryID = 2,
                Title = "Chicken & Vegetables Meal",
                Price = 88,
                Image = "https://images.unsplash.com/photo-1625539990527-914cf510191d?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=764&q=80"
            },
            new Product
            {
                ID = 4,
                CategoryID = 2,
                Title = "SeaFood Pizza",
                Price = 180,
                Image = "https://images.unsplash.com/photo-1565299624946-b28f40a0ae38?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=781&q=80"
            },
            new Product
            {
                ID = 5,
                CategoryID = 3,
                Title = "Burger Sandwich",
                Price = 59,
                Image = "https://images.unsplash.com/photo-1550547660-d9450f859349?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1965&q=80"
            },
            new Product
            {
                ID = 6,
                CategoryID = 3,
                Title = "Classic Cheese Burger",
                Price = 80,
                Image = "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"
            },
            new Product
            {
                ID = 7,
                CategoryID = 1,
                Title = "Cheese Burger & Fries",
                Price = 90,
                Image = "https://images.unsplash.com/photo-1561758033-d89a9ad46330?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1770&q=80"
            },
            new Product
            {
                ID = 8,
                CategoryID = 1,
                Title = "Broast Meal",
                Price = 150,
                Image = "https://images.unsplash.com/photo-1426869981800-95ebf51ce900?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80"
            },
            new Product
            {
                ID = 9,
                CategoryID = 2,
                Title = "Three Double Cheese Burger & Fries",
                Price = 300,
                Image = "https://images.unsplash.com/photo-1610614819513-58e34989848b?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=869&q=80"
            },
            new Product
            {
                ID = 10,
                CategoryID = 2,
                Title = "Pepperoni Pizza",
                Price = 110,
                Image = "https://images.unsplash.com/photo-1628840042765-356cda07504e?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=580&q=80"
            },
            new Product
            {
                ID = 11,
                CategoryID = 3,
                Title = "Triple Cheese Burger",
                Price = 135,
                Image = "https://images.unsplash.com/photo-1617364066121-8a26d640130f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=327&q=80"
            },
            new Product
            {
                ID = 12,
                CategoryID = 3,
                Title = "Cheese Onion Burger",
                Price = 100,
                Image = "https://images.unsplash.com/photo-1561758033-563f9666b8c8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80"
            });

        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Name = "Category 1",
                ID = 1
            },
            new Category
            {
                Name = "Category 2",
                ID = 2
            },
            new Category
            {
                Name = "Category 3",
                ID = 3
            });

        modelBuilder.Entity<Customer>().HasData(
        new Customer
        {
            ID = 1,
            Username = "username1",
            FirstName = "Ramy",
            LastName = "Ahmed",
            Email = "username1@example.com",
            Phone = "2348719749",
            Address = "some address",
            Password = "super secret",
        },
        new Customer
        {

            ID = 2,
            Username = "username2",
            FirstName = "Ayman",
            LastName = "Rady",
            Email = "username2@example.com",
            Phone = "2348719749",
            Address = "some address",
            Password = "super secret",
        });

        modelBuilder.Entity<Order>().HasData(
            new Order
            {
                ID = 1,
                TotalPrice = 800,
                PlacedAt = new DateTime(2020, 4, 1),
                CustomerID = 1,
                Notes = "some notes about the order"
            },
            new Order
            {
                ID = 2,
                TotalPrice = 500,
                PlacedAt = new DateTime(2023, 1, 31),
                CustomerID = 2,
                Notes = "the order needs some salts"
            },
            new Order
            {
                ID = 3,
                TotalPrice = 500,
                PlacedAt = new DateTime(2023, 1, 31),
                CustomerID = 2,
                Notes = "the order needs some salts"
            },
            new Order
            {
                ID = 4,
                TotalPrice = 500,
                PlacedAt = new DateTime(2023, 1, 31),
                CustomerID = 2,
                Notes = "the order needs some salts"
            },
            new Order
            {
                ID = 5,
                TotalPrice = 500,
                PlacedAt = new DateTime(2023, 1, 31),
                CustomerID = 2,
                Notes = "the order needs some salts"
            },

            new Order
            {
                ID = 6,
                TotalPrice = 500,
                PlacedAt = new DateTime(2023, 1, 31),
                CustomerID = 2,
                Notes = "the order needs some salts"
            });

        modelBuilder.Entity<OrderItems>().HasData(
            new OrderItems
            {
                OrderID = 1,
                ProductID = 1,
                Price = 42,
                Quantity = 20
            },
            new OrderItems
            {
                OrderID = 2,
                ProductID = 2,
                Price = 23,
                Quantity = 10
            },
            new OrderItems
            {
                OrderID = 3,
                ProductID = 1,
                Price = 44,
                Quantity = 58
            },
            new OrderItems
            {
                OrderID = 4,
                ProductID = 3,
                Price = 10,
                Quantity = 200
            },
            new OrderItems
            {
                OrderID = 5,
                ProductID = 2,
                Price = 50,
                Quantity = 400
            },
            new OrderItems
            {
                OrderID = 6,
                ProductID = 3,
                Price = 88,
                Quantity = 300
            });
    }
}
