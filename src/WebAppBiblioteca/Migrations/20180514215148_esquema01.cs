using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppBiblioteca.Migrations
{
    public partial class esquema01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriasLibros",
                columns: table => new
                {
                    CodigoCatLibro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreCatLibro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasLibros", x => x.CodigoCatLibro);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    CodigoLibro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AutorLibro = table.Column<string>(nullable: true),
                    CategoriasLibrosCodigoCatLibro = table.Column<int>(nullable: true),
                    CodigoCategoria = table.Column<int>(nullable: false),
                    DescripLibro = table.Column<string>(nullable: true),
                    EditorialLibro = table.Column<string>(nullable: true),
                    EstadoLibro = table.Column<int>(nullable: false),
                    NombreLibro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.CodigoLibro);
                    table.ForeignKey(
                        name: "FK_Libros_CategoriasLibros_CategoriasLibrosCodigoCatLibro",
                        column: x => x.CategoriasLibrosCodigoCatLibro,
                        principalTable: "CategoriasLibros",
                        principalColumn: "CodigoCatLibro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libros_CategoriasLibrosCodigoCatLibro",
                table: "Libros",
                column: "CategoriasLibrosCodigoCatLibro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "CategoriasLibros");
        }
    }
}
