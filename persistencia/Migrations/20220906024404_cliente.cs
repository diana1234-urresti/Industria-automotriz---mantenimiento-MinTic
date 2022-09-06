using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class cliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "cliente");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "ingreso",
                newName: "NameUsuario");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "factura",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "factura");

            migrationBuilder.RenameColumn(
                name: "NameUsuario",
                table: "ingreso",
                newName: "IdUsuario");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
