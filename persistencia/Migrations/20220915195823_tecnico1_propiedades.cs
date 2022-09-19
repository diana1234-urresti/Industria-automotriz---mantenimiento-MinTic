using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class tecnico1_propiedades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cliente_vehiculo_VehiculoId_vehiculo",
                table: "cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_tecnico_vehiculo_VehiculoId_vehiculo",
                table: "tecnico");

            migrationBuilder.DropIndex(
                name: "IX_tecnico_VehiculoId_vehiculo",
                table: "tecnico");

            migrationBuilder.DropIndex(
                name: "IX_cliente_VehiculoId_vehiculo",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "VehiculoId_vehiculo",
                table: "tecnico");

            migrationBuilder.DropColumn(
                name: "VehiculoId_vehiculo",
                table: "cliente");

            migrationBuilder.AddColumn<int>(
                name: "clientesId_cliente",
                table: "vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tecnicosId_tecnico",
                table: "vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_clientesId_cliente",
                table: "vehiculo",
                column: "clientesId_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_tecnicosId_tecnico",
                table: "vehiculo",
                column: "tecnicosId_tecnico");

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculo_cliente_clientesId_cliente",
                table: "vehiculo",
                column: "clientesId_cliente",
                principalTable: "cliente",
                principalColumn: "Id_cliente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_vehiculo_tecnico_tecnicosId_tecnico",
                table: "vehiculo",
                column: "tecnicosId_tecnico",
                principalTable: "tecnico",
                principalColumn: "Id_tecnico",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehiculo_cliente_clientesId_cliente",
                table: "vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_vehiculo_tecnico_tecnicosId_tecnico",
                table: "vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_vehiculo_clientesId_cliente",
                table: "vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_vehiculo_tecnicosId_tecnico",
                table: "vehiculo");

            migrationBuilder.DropColumn(
                name: "clientesId_cliente",
                table: "vehiculo");

            migrationBuilder.DropColumn(
                name: "tecnicosId_tecnico",
                table: "vehiculo");

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId_vehiculo",
                table: "tecnico",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehiculoId_vehiculo",
                table: "cliente",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tecnico_VehiculoId_vehiculo",
                table: "tecnico",
                column: "VehiculoId_vehiculo");

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

            migrationBuilder.AddForeignKey(
                name: "FK_tecnico_vehiculo_VehiculoId_vehiculo",
                table: "tecnico",
                column: "VehiculoId_vehiculo",
                principalTable: "vehiculo",
                principalColumn: "Id_vehiculo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
