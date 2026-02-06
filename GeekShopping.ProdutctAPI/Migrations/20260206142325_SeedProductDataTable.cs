using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProdutctAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 5L, "Material Escolar", "Caderno de 100 folhas", "https://m.media-amazon.com/images/I/61n9s+qj8eL._AC_SX679_.jpg", "Caderno", 19.9m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 6L, "Material Escolar", "Caneta esferográfica azul", "https://m.media-amazon.com/images/I/61n9s+qj8eL._AC_SX679_.jpg", "Caneta", 5.9m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 7L, "Acessórios", "Mochila resistente para o dia a dia", "https://m.media-amazon.com/images/I/61n9s+qj8eL._AC_SX679_.jpg", "Mochila", 99.9m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);
        }
    }
}
