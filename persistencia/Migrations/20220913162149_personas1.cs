using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class personas1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Identificacion",
                table: "persona",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 15);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Identificacion",
                table: "persona",
                type: "float",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);
        }
    }
}
