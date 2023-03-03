using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinCost = table.Column<double>(type: "float", nullable: false),
                    OpeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Category", "ClosingDate", "Condition", "Image", "ItemDescription", "ItemName", "MinCost", "OpeningDate" },
                values: new object[,]
                {
                    { 1, "Shoes", new DateTime(2023, 3, 5, 22, 0, 2, 920, DateTimeKind.Local).AddTicks(428), "Used", "shoes.png", "really cool shoes", "Air Jordan", 100.0, new DateTime(2023, 3, 2, 22, 0, 2, 920, DateTimeKind.Local).AddTicks(398) },
                    { 2, "Shoes", new DateTime(2023, 3, 5, 22, 0, 2, 920, DateTimeKind.Local).AddTicks(433), "New", "nike.jpg", "really really cool shoes", "Nike", 120.0, new DateTime(2023, 3, 2, 22, 0, 2, 920, DateTimeKind.Local).AddTicks(432) },
                    { 3, "Shoes", new DateTime(2023, 3, 5, 22, 0, 2, 920, DateTimeKind.Local).AddTicks(436), "New", "spiderman.jpg", "Cool Spider-man shoes", "Spider-man Shoes", 2000.0, new DateTime(2023, 3, 2, 22, 0, 2, 920, DateTimeKind.Local).AddTicks(435) },
                    { 4, "Sports", new DateTime(2023, 3, 5, 22, 0, 2, 920, DateTimeKind.Local).AddTicks(438), "New", "bicycle.jpg", "Bicycle", "Bicycle", 124.98999999999999, new DateTime(2023, 3, 2, 22, 0, 2, 920, DateTimeKind.Local).AddTicks(437) },
                    { 5, "Phone", new DateTime(2023, 3, 5, 22, 0, 2, 920, DateTimeKind.Local).AddTicks(440), "New", "iPhone13.png", "Iphone 13 128GB", "Iphone 13", 1120.0, new DateTime(2023, 3, 2, 22, 0, 2, 920, DateTimeKind.Local).AddTicks(440) },
                    { 6, "Phone", new DateTime(2023, 3, 5, 22, 0, 2, 920, DateTimeKind.Local).AddTicks(443), "New", "samsung.png", "Samsung Galaxy 23 256GB", "Samsung Galaxy 23", 2000.0, new DateTime(2023, 3, 2, 22, 0, 2, 920, DateTimeKind.Local).AddTicks(442) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "EmailAddress", "Password", "UserType", "Username" },
                values: new object[,]
                {
                    { 1, "Seller1@gmail.ca", "Password", "seller", "" },
                    { 2, "buyer1@gmail.ca", "password1", "buyer", "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
