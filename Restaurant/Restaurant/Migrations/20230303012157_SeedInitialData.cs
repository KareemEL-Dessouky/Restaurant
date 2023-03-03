using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Category 1" },
                    { 2, "Category 2" },
                    { 3, "Category 3" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Address", "Email", "FirstName", "Img", "LastName", "Password", "Phone", "Username" },
                values: new object[,]
                {
                    { 1, "some address", "username1@example.com", "Ramy", null, "Ahmed", "super secret", "2348719749", "username1" },
                    { 2, "some address", "username2@example.com", "Ayman", null, "Rady", "super secret", "2348719749", "username2" }
                });

            migrationBuilder.InsertData(
                table: "CustomerOrders",
                columns: new[] { "ID", "CustomerID", "Notes", "PlacedAt", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, "some notes about the order", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 800 },
                    { 2, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500 },
                    { 3, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500 },
                    { 4, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500 },
                    { 5, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500 },
                    { 6, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, null, 20, "Product 1" },
                    { 2, 1, null, 50, "Product 2" },
                    { 3, 2, null, 88, "Product 3" },
                    { 4, 2, null, 32, "Product 4" },
                    { 5, 3, null, 59, "Product 5" },
                    { 6, 3, null, 200, "Product 6" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderID", "ProductID", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 42, 2 },
                    { 2, 2, 23, 1 },
                    { 3, 1, 44, 5 },
                    { 4, 3, 10, 2 },
                    { 5, 2, 50, 4 },
                    { 6, 3, 88, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
