using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.Repository.Migrations
{
    public partial class nova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrders_Orders_OrderId",
                table: "ProductInOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrders_Products_ProductId",
                table: "ProductInOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCarts_Products_ProductId",
                table: "ProductInShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_ShoppingCardId",
                table: "ProductInShoppingCarts");

            migrationBuilder.CreateTable(
                name: "EmailMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    MailTo = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailMessages", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrders_Products_OrderId",
                table: "ProductInOrders",
                column: "OrderId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrders_Orders_ProductId",
                table: "ProductInOrders",
                column: "ProductId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_ProductId",
                table: "ProductInShoppingCarts",
                column: "ProductId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCarts_Products_ShoppingCardId",
                table: "ProductInShoppingCarts",
                column: "ShoppingCardId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrders_Products_OrderId",
                table: "ProductInOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInOrders_Orders_ProductId",
                table: "ProductInOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_ProductId",
                table: "ProductInShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInShoppingCarts_Products_ShoppingCardId",
                table: "ProductInShoppingCarts");

            migrationBuilder.DropTable(
                name: "EmailMessages");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrders_Orders_OrderId",
                table: "ProductInOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInOrders_Products_ProductId",
                table: "ProductInOrders",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCarts_Products_ProductId",
                table: "ProductInShoppingCarts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInShoppingCarts_ShoppingCarts_ShoppingCardId",
                table: "ProductInShoppingCarts",
                column: "ShoppingCardId",
                principalTable: "ShoppingCarts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
