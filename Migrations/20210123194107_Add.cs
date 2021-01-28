using Microsoft.EntityFrameworkCore.Migrations;

namespace Classics_Shop.Migrations
{
    public partial class Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "products",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "UnitPrice",
                value: 60000.78m);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "UnitPrice",
                value: 70000.11m);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "UnitPrice",
                value: 30000.8m);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "UnitPrice",
                value: 40000.0m);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "UnitPrice",
                value: 10000.0m);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "UnitPrice",
                value: 14000.8m);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "UnitPrice",
                value: 20000.90m);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "UnitPrice",
                value: 20000.90m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "UnitPrice",
                table: "products",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "UnitPrice",
                value: 60000.779999999999);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "UnitPrice",
                value: 70000.110000000001);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "UnitPrice",
                value: 30000.799999999999);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 5,
                column: "UnitPrice",
                value: 40000.0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 6,
                column: "UnitPrice",
                value: 10000.0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 7,
                column: "UnitPrice",
                value: 14000.799999999999);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 8,
                column: "UnitPrice",
                value: 20000.900000000001);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 9,
                column: "UnitPrice",
                value: 20000.900000000001);
        }
    }
}
