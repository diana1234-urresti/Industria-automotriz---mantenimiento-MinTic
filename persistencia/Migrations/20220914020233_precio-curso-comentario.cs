using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class preciocursocomentario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "comentario",
                columns: table => new
                {
                    ComentarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alumno = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Puntaje = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    ComentarioTexto = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CursoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comentario", x => x.ComentarioId);
                    table.ForeignKey(
                        name: "FK_comentario_curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "curso",
                        principalColumn: "CursoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comentario_CursoId",
                table: "comentario",
                column: "CursoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comentario");
        }
    }
}
