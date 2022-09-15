using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class vehiculo_tecnico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tecnico",
                newName: "Id_tecnico");

            migrationBuilder.AddColumn<int>(
                name: "Id_tecnico",
                table: "vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId_vehiculo",
                table: "tecnico",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tecnico_VehiculoId_vehiculo",
                table: "tecnico",
                column: "VehiculoId_vehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_tecnico_vehiculo_VehiculoId_vehiculo",
                table: "tecnico",
                column: "VehiculoId_vehiculo",
                principalTable: "vehiculo",
                principalColumn: "Id_vehiculo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tecnico_vehiculo_VehiculoId_vehiculo",
                table: "tecnico");

            migrationBuilder.DropIndex(
                name: "IX_tecnico_VehiculoId_vehiculo",
                table: "tecnico");

            migrationBuilder.DropColumn(
                name: "Id_tecnico",
                table: "vehiculo");

            migrationBuilder.DropColumn(
                name: "VehiculoId_vehiculo",
                table: "tecnico");

            migrationBuilder.RenameColumn(
                name: "Id_tecnico",
                table: "tecnico",
                newName: "Id");
        }
    }
}
