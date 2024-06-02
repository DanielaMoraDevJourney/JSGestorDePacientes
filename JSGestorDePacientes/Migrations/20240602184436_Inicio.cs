using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JSGestorDePacientes.Migrations
{
    /// <inheritdoc />
    public partial class Inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JSCategoria",
                columns: table => new
                {
                    JSIdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JSGravedad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JSFechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JSPacienteJSIdPaciente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JSCategoria", x => x.JSIdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "JSPaciente",
                columns: table => new
                {
                    JSIdPaciente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JSNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JSApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JSEnfermedad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JSDNI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JSIdCategoria = table.Column<int>(type: "int", nullable: false),
                    JSCategoriaJSIdCategoria = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JSPaciente", x => x.JSIdPaciente);
                    table.ForeignKey(
                        name: "FK_JSPaciente_JSCategoria_JSCategoriaJSIdCategoria",
                        column: x => x.JSCategoriaJSIdCategoria,
                        principalTable: "JSCategoria",
                        principalColumn: "JSIdCategoria");
                });

            migrationBuilder.CreateIndex(
                name: "IX_JSCategoria_JSPacienteJSIdPaciente",
                table: "JSCategoria",
                column: "JSPacienteJSIdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_JSPaciente_JSCategoriaJSIdCategoria",
                table: "JSPaciente",
                column: "JSCategoriaJSIdCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_JSCategoria_JSPaciente_JSPacienteJSIdPaciente",
                table: "JSCategoria",
                column: "JSPacienteJSIdPaciente",
                principalTable: "JSPaciente",
                principalColumn: "JSIdPaciente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JSCategoria_JSPaciente_JSPacienteJSIdPaciente",
                table: "JSCategoria");

            migrationBuilder.DropTable(
                name: "JSPaciente");

            migrationBuilder.DropTable(
                name: "JSCategoria");
        }
    }
}
