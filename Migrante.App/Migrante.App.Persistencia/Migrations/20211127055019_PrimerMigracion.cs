using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Migrante.App.Persistencia.Migrations
{
    public partial class PrimerMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Migrantes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tipoIdentificacion = table.Column<int>(type: "int", nullable: false),
                    numeroDocumento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    país = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    direccionElectronica = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    situacionLaboral = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Migrantes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Migrantes");
        }
    }
}
