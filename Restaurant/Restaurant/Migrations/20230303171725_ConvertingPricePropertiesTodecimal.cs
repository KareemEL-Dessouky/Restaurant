using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.Migrations
{
    /// <inheritdoc />
    public partial class ConvertingPricePropertiesTodecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "OrderItems",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "CustomerOrders",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                column: "TotalPrice",
                value: 500m);

            migrationBuilder.UpdateData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 3,
                column: "TotalPrice",
                value: 500m);

            migrationBuilder.UpdateData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 4,
                column: "TotalPrice",
                value: 500m);

            migrationBuilder.UpdateData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 5,
                column: "TotalPrice",
                value: 500m);

            migrationBuilder.UpdateData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 6,
                column: "TotalPrice",
                value: 500m);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                column: "Price",
                value: 42m);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                column: "Price",
                value: 23m);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 1 },
                column: "Price",
                value: 44m);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 3 },
                column: "Price",
                value: 10m);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 2 },
                column: "Price",
                value: 50m);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 3 },
                column: "Price",
                value: 88m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "Price",
                value: 20m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "Price",
                value: 50m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                column: "Price",
                value: 88m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                column: "Price",
                value: 32m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                column: "Price",
                value: 59m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                column: "Price",
                value: 200m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "OrderItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "TotalPrice",
                table: "CustomerOrders",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 1,
                column: "TotalPrice",
                value: 800);

            migrationBuilder.UpdateData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 2,
                column: "TotalPrice",
                value: 500);

            migrationBuilder.UpdateData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 3,
                column: "TotalPrice",
                value: 500);

            migrationBuilder.UpdateData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 4,
                column: "TotalPrice",
                value: 500);

            migrationBuilder.UpdateData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 5,
                column: "TotalPrice",
                value: 500);

            migrationBuilder.UpdateData(
                table: "CustomerOrders",
                keyColumn: "ID",
                keyValue: 6,
                column: "TotalPrice",
                value: 500);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 1, 1 },
                column: "Price",
                value: 42);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 2, 2 },
                column: "Price",
                value: 23);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 3, 1 },
                column: "Price",
                value: 44);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 4, 3 },
                column: "Price",
                value: 10);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 5, 2 },
                column: "Price",
                value: 50);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumns: new[] { "OrderID", "ProductID" },
                keyValues: new object[] { 6, 3 },
                column: "Price",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                column: "Price",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                column: "Price",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                column: "Price",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                column: "Price",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                column: "Price",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                column: "Price",
                value: 200);
        }
    }
}
