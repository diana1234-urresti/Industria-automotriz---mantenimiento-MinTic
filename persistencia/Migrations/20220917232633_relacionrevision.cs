using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class relacionrevision : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoPlaca",
                table: "revision");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "revision",
                newName: "Id_revision");

            migrationBuilder.AddColumn<int>(
                name: "Id_revision",
                table: "vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId_vehiculo",
                table: "revision",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_revision_VehiculoId_vehiculo",
                table: "revision",
                column: "VehiculoId_vehiculo");

            migrationBuilder.AddForeignKey(
                name: "FK_revision_vehiculo_VehiculoId_vehiculo",
                table: "revision",
                column: "VehiculoId_vehiculo",
                principalTable: "vehiculo",
                principalColumn: "Id_vehiculo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_revision_vehiculo_VehiculoId_vehiculo",
                table: "revision");

            migrationBuilder.DropIndex(
                name: "IX_revision_VehiculoId_vehiculo",
                table: "revision");

            migrationBuilder.DropColumn(
                name: "Id_revision",
                table: "vehiculo");

            migrationBuilder.DropColumn(
                name: "VehiculoId_vehiculo",
                table: "revision");

            migrationBuilder.RenameColumn(
                name: "Id_revision",
                table: "revision",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "NoPlaca",
                table: "revision",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
