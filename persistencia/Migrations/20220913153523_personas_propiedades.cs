using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class personas_propiedades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ingresos",
                table: "ingresos");

            migrationBuilder.RenameTable(
                name: "ingresos",
                newName: "Ingreso");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "persona",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "persona",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "persona",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaN",
                table: "persona",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Identificacion",
                table: "persona",
                type: "float",
                maxLength: 15,
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Telefono",
                table: "persona",
                type: "int",
                maxLength: 15,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingreso",
                table: "Ingreso",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingreso",
                table: "Ingreso");

            migrationBuilder.DropColumn(
                name: "FechaN",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "Identificacion",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "persona");

            migrationBuilder.RenameTable(
                name: "Ingreso",
                newName: "ingresos");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "persona",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "persona",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "persona",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ingresos",
                table: "ingresos",
                column: "Id");
        }
    }
}
