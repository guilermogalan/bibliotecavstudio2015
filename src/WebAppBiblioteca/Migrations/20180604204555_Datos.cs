using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppBiblioteca.Migrations
{
    public partial class Datos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NivUsuarios",
                columns: table => new
                {
                    CodigoNivel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreNivel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivUsuarios", x => x.CodigoNivel);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    CodigoUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoNivel = table.Column<int>(nullable: false),
                    DireccionUsuario = table.Column<string>(nullable: true),
                    EstadoUsuario = table.Column<string>(nullable: true),
                    ImagenURL = table.Column<string>(nullable: true),
                    ImagenUsuarioURL = table.Column<string>(nullable: true),
                    NombreUsuario = table.Column<string>(nullable: true),
                    UsernameUsuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.CodigoUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_NivUsuarios_CodigoNivel",
                        column: x => x.CodigoNivel,
                        principalTable: "NivUsuarios",
                        principalColumn: "CodigoNivel",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CodigoNivel",
                table: "Usuarios",
                column: "CodigoNivel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "NivUsuarios");
        }
    }
}
