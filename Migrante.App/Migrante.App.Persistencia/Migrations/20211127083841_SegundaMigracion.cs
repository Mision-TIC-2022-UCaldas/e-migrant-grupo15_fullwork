using Microsoft.EntityFrameworkCore.Migrations;

namespace Migrante.App.Persistencia.Migrations
{
    public partial class SegundaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ciudad",
                table: "Migrantes",
                newName: "ciudad");

            migrationBuilder.RenameColumn(
                name: "país",
                table: "Migrantes",
                newName: "pais");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ciudad",
                table: "Migrantes",
                newName: "Ciudad");

            migrationBuilder.RenameColumn(
                name: "pais",
                table: "Migrantes",
                newName: "país");
        }
    }
}
