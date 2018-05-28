using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppBiblioteca.Migrations
{
    public partial class DataInicio : Migration
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
                    CatLibrosCodigoCatLibro = table.Column<int>(nullable: true),
                    CodigoCategoria = table.Column<int>(nullable: false),
                    DescripCortaLibro = table.Column<string>(nullable: true),
                    DescripLargaLibro = table.Column<string>(nullable: true),
                    DescripLibro = table.Column<string>(nullable: true),
                    EstadoLibro = table.Column<bool>(nullable: false),
                    ImagenPreviaURL = table.Column<string>(nullable: true),
                    ImagenURL = table.Column<string>(nullable: true),
                    LibroDestacado = table.Column<bool>(nullable: false),
                    LibroEnExistencia = table.Column<bool>(nullable: false),
                    NombreLibro = table.Column<string>(nullable: true),
                    PreCostoLibro = table.Column<decimal>(nullable: false),
                    PreVentaLibro = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.CodigoLibro);
                    table.ForeignKey(
                        name: "FK_Libros_CategoriasLibros_CatLibrosCodigoCatLibro",
                        column: x => x.CatLibrosCodigoCatLibro,
                        principalTable: "CategoriasLibros",
                        principalColumn: "CodigoCatLibro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libros_CatLibrosCodigoCatLibro",
                table: "Libros",
                column: "CatLibrosCodigoCatLibro");
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
