using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class personas_carros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Id_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaN = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Identificacion = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.Id_cliente);
                });

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
                name: "factura",
                columns: table => new
                {
                    Id_factura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaFacturacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CostoRevision = table.Column<double>(type: "float", nullable: false),
                    CostoRepuesto = table.Column<double>(type: "float", nullable: false),
                    Iva = table.Column<double>(type: "float", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factura", x => x.Id_factura);
                });

            migrationBuilder.CreateTable(
                name: "Ingreso",
                columns: table => new
                {
                    Id_ingreso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingreso", x => x.Id_ingreso);
                });

            migrationBuilder.CreateTable(
                name: "persona",
                columns: table => new
                {
                    Id_persona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaN = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Identificacion = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persona", x => x.Id_persona);
                });

            migrationBuilder.CreateTable(
                name: "repuesto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    NombreParte = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_repuesto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tecnico",
                columns: table => new
                {
                    Id_tecnico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaN = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Identificacion = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Sueldo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tecnico", x => x.Id_tecnico);
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

            migrationBuilder.CreateTable(
                name: "vehiculo",
                columns: table => new
                {
                    Id_vehiculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo_de_falla = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Id_cliente = table.Column<int>(type: "int", nullable: false),
                    Id_tecnico = table.Column<int>(type: "int", nullable: false),
                    clientesId_cliente = table.Column<int>(type: "int", nullable: true),
                    tecnicosId_tecnico = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiculo", x => x.Id_vehiculo);
                    table.ForeignKey(
                        name: "FK_vehiculo_cliente_clientesId_cliente",
                        column: x => x.clientesId_cliente,
                        principalTable: "cliente",
                        principalColumn: "Id_cliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_vehiculo_tecnico_tecnicosId_tecnico",
                        column: x => x.tecnicosId_tecnico,
                        principalTable: "tecnico",
                        principalColumn: "Id_tecnico",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "revision",
                columns: table => new
                {
                    Id_revision = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoRevision = table.Column<int>(type: "int", nullable: false),
                    VehiculoId_vehiculo = table.Column<int>(type: "int", nullable: true),
                    TipoMantenimiento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaRevision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoFiltro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Repuesto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EstadoAceite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_revision", x => x.Id_revision);
                    table.ForeignKey(
                        name: "FK_revision_vehiculo_VehiculoId_vehiculo",
                        column: x => x.VehiculoId_vehiculo,
                        principalTable: "vehiculo",
                        principalColumn: "Id_vehiculo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_precio_CursoId",
                table: "precio",
                column: "CursoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_revision_VehiculoId_vehiculo",
                table: "revision",
                column: "VehiculoId_vehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_clientesId_cliente",
                table: "vehiculo",
                column: "clientesId_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculo_tecnicosId_tecnico",
                table: "vehiculo",
                column: "tecnicosId_tecnico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "factura");

            migrationBuilder.DropTable(
                name: "Ingreso");

            migrationBuilder.DropTable(
                name: "persona");

            migrationBuilder.DropTable(
                name: "precio");

            migrationBuilder.DropTable(
                name: "repuesto");

            migrationBuilder.DropTable(
                name: "revision");

            migrationBuilder.DropTable(
                name: "curso");

            migrationBuilder.DropTable(
                name: "vehiculo");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "tecnico");
        }
    }
}
