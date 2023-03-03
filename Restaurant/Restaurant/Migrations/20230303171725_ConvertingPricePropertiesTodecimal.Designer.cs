﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant.Models;

#nullable disable

namespace Restaurant.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20230303171725_ConvertingPricePropertiesTodecimal")]
    partial class ConvertingPricePropertiesTodecimal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Restaurant.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Category 1"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Category 2"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Category 3"
                        });
                });

            modelBuilder.Entity("Restaurant.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "some address",
                            Email = "username1@example.com",
                            FirstName = "Ramy",
                            LastName = "Ahmed",
                            Password = "super secret",
                            Phone = "2348719749",
                            Username = "username1"
                        },
                        new
                        {
                            ID = 2,
                            Address = "some address",
                            Email = "username2@example.com",
                            FirstName = "Ayman",
                            LastName = "Rady",
                            Password = "super secret",
                            Phone = "2348719749",
                            Username = "username2"
                        });
                });

            modelBuilder.Entity("Restaurant.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PlacedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.ToTable("CustomerOrders");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CustomerID = 1,
                            Notes = "some notes about the order",
                            PlacedAt = new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalPrice = 800m
                        },
                        new
                        {
                            ID = 2,
                            CustomerID = 2,
                            Notes = "the order needs some salts",
                            PlacedAt = new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalPrice = 500m
                        },
                        new
                        {
                            ID = 3,
                            CustomerID = 2,
                            Notes = "the order needs some salts",
                            PlacedAt = new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalPrice = 500m
                        },
                        new
                        {
                            ID = 4,
                            CustomerID = 2,
                            Notes = "the order needs some salts",
                            PlacedAt = new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalPrice = 500m
                        },
                        new
                        {
                            ID = 5,
                            CustomerID = 2,
                            Notes = "the order needs some salts",
                            PlacedAt = new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalPrice = 500m
                        },
                        new
                        {
                            ID = 6,
                            CustomerID = 2,
                            Notes = "the order needs some salts",
                            PlacedAt = new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalPrice = 500m
                        });
                });

            modelBuilder.Entity("Restaurant.Models.OrderItems", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            OrderID = 1,
                            ProductID = 1,
                            Price = 42m,
                            Quantity = 2
                        },
                        new
                        {
                            OrderID = 2,
                            ProductID = 2,
                            Price = 23m,
                            Quantity = 1
                        },
                        new
                        {
                            OrderID = 3,
                            ProductID = 1,
                            Price = 44m,
                            Quantity = 5
                        },
                        new
                        {
                            OrderID = 4,
                            ProductID = 3,
                            Price = 10m,
                            Quantity = 2
                        },
                        new
                        {
                            OrderID = 5,
                            ProductID = 2,
                            Price = 50m,
                            Quantity = 4
                        },
                        new
                        {
                            OrderID = 6,
                            ProductID = 3,
                            Price = 88m,
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("Restaurant.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 1,
                            Price = 20m,
                            Title = "Product 1"
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 1,
                            Price = 50m,
                            Title = "Product 2"
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = 2,
                            Price = 88m,
                            Title = "Product 3"
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = 2,
                            Price = 32m,
                            Title = "Product 4"
                        },
                        new
                        {
                            ID = 5,
                            CategoryID = 3,
                            Price = 59m,
                            Title = "Product 5"
                        },
                        new
                        {
                            ID = 6,
                            CategoryID = 3,
                            Price = 200m,
                            Title = "Product 6"
                        });
                });

            modelBuilder.Entity("Restaurant.Models.Order", b =>
                {
                    b.HasOne("Restaurant.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Restaurant.Models.OrderItems", b =>
                {
                    b.HasOne("Restaurant.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurant.Models.Product", "Product")
                        .WithMany("Items")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Restaurant.Models.Product", b =>
                {
                    b.HasOne("Restaurant.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Restaurant.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Restaurant.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Restaurant.Models.Order", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Restaurant.Models.Product", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
