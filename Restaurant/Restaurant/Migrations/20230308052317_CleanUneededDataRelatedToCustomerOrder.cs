using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant.Migrations
{
    /// <inheritdoc />
    public partial class CleanUneededDataRelatedToCustomerOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 1,
                column: "TotalPrice",
                value: 20m);

            migrationBuilder.UpdateData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CustomerID", "TotalPrice" },
                values: new object[] { 1, 20m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 10m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 20m, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 1,
                column: "TotalPrice",
                value: 800m);

            migrationBuilder.UpdateData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CustomerID", "TotalPrice" },
                values: new object[] { 2, 500m });

            migrationBuilder.InsertData(
                table: "CustomerOrders",
                columns: new[] { "ID", "CustomerID", "Notes", "PlacedAt", "TotalPrice" },
                values: new object[,]
                {
                    { 3, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m },
                    { 4, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m },
                    { 5, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m },
                    { 6, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m },
                    { 7, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m },
                    { 8, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m },
                    { 9, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m },
                    { 10, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m },
                    { 11, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m },
                    { 12, 2, "the order needs some salts", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m }
                });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 42m, 20 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Price", "Quantity" },
                values: new object[] { 23m, 10 });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderID", "ProductID", "Price", "Quantity" },
                values: new object[,]
                {
                    { 3, 1, 44m, 58 },
                    { 4, 3, 10m, 200 },
                    { 5, 2, 50m, 400 },
                    { 6, 3, 88m, 300 },
                    { 7, 4, 88m, 300 },
                    { 8, 3, 88m, 300 },
                    { 9, 8, 88m, 300 },
                    { 10, 12, 88m, 300 },
                    { 11, 6, 88m, 300 },
                    { 12, 11, 88m, 300 }
                });
        }
    }
}
