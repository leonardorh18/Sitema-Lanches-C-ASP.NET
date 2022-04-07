using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome, Descricao) " +
                "values ('Normal', 'Lanches feios com ingredientes normais.')");

            migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome, Descricao) " +
                "values ('Natural', 'Lanches feios com ingredientes naturais.')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from categoria");
        }
    }
}
