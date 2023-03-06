﻿using Microsoft.EntityFrameworkCore;

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
                Title = "Product 1",
                Price = 20,
                Image = "https://images.unsplash.com/photo-1615719413546-198b25453f85?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=736&q=80"
            },
            new Product
            {
                ID = 2,
                CategoryID = 1,
                Title = "Product 2",
                Price = 50,
                Image = "https://images.unsplash.com/photo-1619221882220-947b3d3c8861?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"
            },
            new Product
            {
                ID = 3,
                CategoryID = 2,
                Title = "Product 3",
                Price = 88,
                Image = "https://images.unsplash.com/photo-1625539990527-914cf510191d?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=764&q=80"
            },
            new Product
            {
                ID = 4,
                CategoryID = 2,
                Title = "Product 4",
                Price = 32,
                Image = "https://images.unsplash.com/photo-1565299624946-b28f40a0ae38?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=781&q=80"
            },
            new Product
            {
                ID = 5,
                CategoryID = 3,
                Title = "Product 5",
                Price = 59,
                Image = ""
            },
            new Product
            {
                ID = 6,
                CategoryID = 3,
                Title = "Product 6",
                Price = 200,
                Image = "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80"
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
                Quantity = 2
            },
            new OrderItems
            {
                OrderID = 2,
                ProductID = 2,
                Price = 23,
                Quantity = 1
            },
            new OrderItems
            {
                OrderID = 3,
                ProductID = 1,
                Price = 44,
                Quantity = 5
            },
            new OrderItems
            {
                OrderID = 4,
                ProductID = 3,
                Price = 10,
                Quantity = 2
            },
            new OrderItems
            {
                OrderID = 5,
                ProductID = 2,
                Price = 50,
                Quantity = 4
            },
            new OrderItems
            {
                OrderID = 6,
                ProductID = 3,
                Price = 88,
                Quantity = 3
            });
    }
}
