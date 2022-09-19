using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class cliente_tecnico_propiedades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "persona",
                newName: "Id_persona");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "tecnico",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "tecnico",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "tecnico",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaN",
                table: "tecnico",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Identificacion",
                table: "tecnico",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "tecnico",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "tecnico",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "cliente",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "cliente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "cliente",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaN",
                table: "cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Identificacion",
                table: "cliente",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "cliente",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "cliente",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "tecnico");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "tecnico");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "tecnico");

            migrationBuilder.DropColumn(
                name: "FechaN",
                table: "tecnico");

            migrationBuilder.DropColumn(
                name: "Identificacion",
                table: "tecnico");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "tecnico");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "tecnico");

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "FechaN",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "Identificacion",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "cliente");

            migrationBuilder.RenameColumn(
                name: "Id_persona",
                table: "persona",
                newName: "Id");
        }
    }
}
