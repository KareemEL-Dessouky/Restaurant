using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Restaurant.Migrations
{
    /// <inheritdoc />
    public partial class AdditionOfSixProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                column: "Quantity",
                value: 20);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                column: "Quantity",
                value: 10);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 1 },
                column: "Quantity",
                value: 58);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 3 },
                column: "Quantity",
                value: 200);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 2 },
                column: "Quantity",
                value: 400);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 3 },
                column: "Quantity",
                value: 300);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "Title",
                value: "Chicken Pizza");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Price", "Title" },
                values: new object[] { 250m, "Shrimp Meal" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                column: "Title",
                value: "Chicken & Vegetables Meal");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Price", "Title" },
                values: new object[] { 180m, "SeaFood Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Image", "Title" },
                values: new object[] { "https://images.unsplash.com/photo-1550547660-d9450f859349?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1965&q=80", "Burger Sandwich" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Price", "Title" },
                values: new object[] { 80m, "Classic Cheese Burger" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { 7, 1, "https://images.unsplash.com/photo-1561758033-d89a9ad46330?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1770&q=80", 90m, "Cheese Burger & Fries" },
                    { 8, 1, "https://images.unsplash.com/photo-1426869981800-95ebf51ce900?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 150m, "Broast Meal" },
                    { 9, 2, "https://images.unsplash.com/photo-1610614819513-58e34989848b?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=869&q=80", 300m, "Three Double Cheese Burger & Fries" },
                    { 10, 2, "https://images.unsplash.com/photo-1628840042765-356cda07504e?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=580&q=80", 110m, "Pepperoni Pizza" },
                    { 11, 3, "https://images.unsplash.com/photo-1617364066121-8a26d640130f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=327&q=80", 135m, "Triple Cheese Burger" },
                    { 12, 3, "https://images.unsplash.com/photo-1561758033-563f9666b8c8?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80", 100m, "Cheese Onion Burger" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                column: "Quantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 1 },
                column: "Quantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 3 },
                column: "Quantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 2 },
                column: "Quantity",
                value: 4);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 3 },
                column: "Quantity",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "Title",
                value: "Product 1");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Price", "Title" },
                values: new object[] { 50m, "Product 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                column: "Title",
                value: "Product 3");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Price", "Title" },
                values: new object[] { 32m, "Product 4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Image", "Title" },
                values: new object[] { "", "Product 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Price", "Title" },
                values: new object[] { 200m, "Product 6" });
        }
    }
}
