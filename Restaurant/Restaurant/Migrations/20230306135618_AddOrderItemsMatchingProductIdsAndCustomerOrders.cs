using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderItemsMatchingProductIdsAndCustomerOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CustomerOrders",
                columns: new[] { "ID", "CustomerID", "Notes", "PlacedAt", "TotalPrice" },
                values: new object[,]
                {
                    { 7, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m },
                    { 8, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m },
                    { 9, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m },
                    { 10, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m },
                    { 11, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m },
                    { 12, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderID", "ProductID", "Price", "Quantity" },
                values: new object[,]
                {
                    { 7, 4, 88m, 300 },
                    { 8, 3, 88m, 300 },
                    { 9, 8, 88m, 300 },
                    { 10, 12, 88m, 300 },
                    { 11, 6, 88m, 300 },
                    { 12, 11, 88m, 300 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 10, 12 });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 12);
        }
    }
}
