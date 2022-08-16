using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_Api_Task.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_Category_categoryId",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_categoryId",
                table: "product");

            migrationBuilder.DropColumn(
                name: "categoryId",
                table: "product");

            migrationBuilder.CreateIndex(
                name: "IX_product_Cat_id",
                table: "product",
                column: "Cat_id");

            migrationBuilder.AddForeignKey(
                name: "FK_product_Category_Cat_id",
                table: "product",
                column: "Cat_id",
                principalTable: "Category",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_Category_Cat_id",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_Cat_id",
                table: "product");

            migrationBuilder.AddColumn<int>(
                name: "categoryId",
                table: "product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_product_categoryId",
                table: "product",
                column: "categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_product_Category_categoryId",
                table: "product",
                column: "categoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }
    }
}
