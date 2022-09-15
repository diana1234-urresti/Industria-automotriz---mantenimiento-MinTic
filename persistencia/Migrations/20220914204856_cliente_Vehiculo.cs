using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class cliente_Vehiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comentario");

            migrationBuilder.DropColumn(
                name: "TipoVehiculo",
                table: "cliente");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "cliente",
                newName: "Id_cliente");

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId_vehiculo",
                table: "cliente",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "vehiculo",
                columns: table => new
                {
                    Id_vehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Matricula = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Id_cliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiculo", x => x.Id_vehiculo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cliente_VehiculoId_vehiculo",
                table: "cliente",
                column: "VehiculoId_vehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_vehiculo_VehiculoId_vehiculo",
                table: "cliente",
                column: "VehiculoId_vehiculo",
                principalTable: "vehiculo",
                principalColumn: "Id_vehiculo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cliente_vehiculo_VehiculoId_vehiculo",
                table: "cliente");

            migrationBuilder.DropTable(
                name: "vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_cliente_VehiculoId_vehiculo",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "VehiculoId_vehiculo",
                table: "cliente");

            migrationBuilder.RenameColumn(
                name: "Id_cliente",
                table: "cliente",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "TipoVehiculo",
                table: "cliente",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "comentario",
                columns: table => new
                {
                    ComentarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Alumno = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ComentarioTexto = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    CursoId = table.Column<int>(type: "int", nullable: false),
                    Puntaje = table.Column<int>(type: "int", maxLength: 50, nullable: false)
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
    }
}
