using Microsoft.EntityFrameworkCore.Migrations;

namespace Classics_Shop.Migrations
{
    public partial class addingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "arivals",
                columns: new[] { "ID", "CategoryID", "Description", "ImagePath", "ProductName", "UnitPrice" },
                values: new object[,]
                {
                    { 6, null, "296 calendar men's watch waterproof quartz watch is one of the most cool whatch to have in town. Buy one for yourself today.", "whatch3.jpeg", "296 calendar men's watch waterproof quartz watch", 10000.0m },
                    { 7, null, "Men watches casual sports watch is a waterproof quartz watch is one of the most cool whatch to have in town. Buy one for yourself today.", "whatch4.jpeg", "Men watches casual sports watch", 14000.8m },
                    { 8, null, "Business brogue suede dress shoes is affordable and clean shoe you wou;d like to have and enjoy it.", "s1.jpeg", "Men fashion business brogue suede dress shoes", 20000.90m },
                    { 9, null, "Men's Shoes Fall 2019 Sports Shoes Men's Fashion Leisure Shoes A Generic PU Small White Shoe", "s2.jpeg", "Leisure Shoes", 20000.90m }
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryID", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Computer & Office", null },
                    { 2, "Clothing", null },
                    { 3, "Shoe", null },
                    { 4, "Luggage & Bags", null },
                    { 5, "Watch & Jewelry", null },
                    { 6, "Home & Appliances", null },
                    { 7, "Phones & Tel", null }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "ProductID", "CategoryID", "Description", "ImagePath", "ProductName", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, "sweet 2.4G Ultra Slim wireless keyboard Portable Mute Keys Keyboards mouse combos for Mac Win XP 7 wireless Keyboard and mouse", "image1.jpeg", "Keyboards", 60000.779999999999 },
                    { 2, 1, "Wireless Keyboard  Ultra Slim wireless keyboard Portable Mute Keys Keyboards mouse combos for Mac Win XP 7 wireless Keyboard and mouse", "image12.jpeg", "Wireless Keyboard and Mouse Mini Multimedia", 70000.110000000001 },
                    { 8, 2, "Business brogue suede dress shoes is affordable and clean shoe you wou;d like to have and enjoy it.", "s1.jpeg", "Men fashion business brogue suede dress shoes", 20000.900000000001 },
                    { 9, 2, "Men's Shoes Fall 2019 Sports Shoes Men's Fashion Leisure Shoes A Generic PU Small White Shoe", "s2.jpeg", "Leisure Shoes", 20000.900000000001 },
                    { 3, 5, "Get one of these whatch. You will love it. This will change your life style", "whatch2.jpeg", "Simple Fashion Casual Business Watches", 30000.799999999999 },
                    { 5, 5, "Get one of these whatch. You will love it. This will change your life style", "whatch1.jpeg", "SKMEI Luxury Men Watch Fashion Casual Watches", 40000.0 },
                    { 6, 5, "296 calendar men's watch waterproof quartz watch is one of the most cool whatch to have in town. Buy one for yourself today.", "whatch3.jpeg", "296 calendar men's watch waterproof quartz watch", 10000.0 },
                    { 7, 5, "Men watches casual sports watch is a waterproof quartz watch is one of the most cool whatch to have in town. Buy one for yourself today.", "whatch4.jpeg", "Men watches casual sports watch", 14000.799999999999 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "arivals",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "arivals",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "arivals",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "arivals",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryID",
                keyValue: 5);
        }
    }
}
