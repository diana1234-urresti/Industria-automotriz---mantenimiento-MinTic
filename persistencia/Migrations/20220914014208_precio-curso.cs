using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class preciocurso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "curso",
                columns: table => new
                {
                    CursoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: false),
                    fotoPortada = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_curso", x => x.CursoId);
                });

            migrationBuilder.CreateTable(
                name: "precio",
                columns: table => new
                {
                    PrecioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecioActual = table.Column<decimal>(type: "decimal(18,2)", maxLength: 100, nullable: false),
                    Promocion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CursoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_precio", x => x.PrecioId);
                    table.ForeignKey(
                        name: "FK_precio_curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "curso",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_precio_CursoId",
                table: "precio",
                column: "CursoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "precio");

            migrationBuilder.DropTable(
                name: "curso");
        }
    }
}
