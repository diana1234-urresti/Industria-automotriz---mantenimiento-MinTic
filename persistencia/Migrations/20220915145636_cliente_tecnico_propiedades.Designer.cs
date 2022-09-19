﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using persistencia;

namespace persistencia.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220915145636_cliente_tecnico_propiedades")]
    partial class cliente_tecnico_propiedades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("dominio.Cliente", b =>
                {
                    b.Property<int>("Id_cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaN")
                        .HasColumnType("datetime2");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("VehiculoId_vehiculo")
                        .HasColumnType("int");

                    b.HasKey("Id_cliente");

                    b.HasIndex("VehiculoId_vehiculo");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("dominio.Curso", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("fotoPortada")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("CursoId");

                    b.ToTable("curso");
                });

            modelBuilder.Entity("dominio.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("CostoRepuesto")
                        .HasColumnType("float");

                    b.Property<double>("CostoRevision")
                        .HasColumnType("float");

                    b.Property<string>("FechaFacturacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Iva")
                        .HasColumnType("float");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("factura");
                });

            modelBuilder.Entity("dominio.Ingreso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingreso");
                });

            modelBuilder.Entity("dominio.Persona", b =>
                {
                    b.Property<int>("Id_persona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("FechaN")
                        .HasColumnType("datetime2");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id_persona");

                    b.ToTable("persona");
                });

            modelBuilder.Entity("dominio.Precio", b =>
                {
                    b.Property<int>("PrecioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioActual")
                        .HasMaxLength(100)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Promocion")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PrecioId");

                    b.HasIndex("CursoId")
                        .IsUnique();

                    b.ToTable("precio");
                });

            modelBuilder.Entity("dominio.Repuesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NombreParte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("repuesto");
                });

            modelBuilder.Entity("dominio.Revision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EstadoAceite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoFiltro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaRevision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoPlaca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoRevision")
                        .HasColumnType("int");

                    b.Property<string>("Repuesto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoMantenimiento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("revision");
                });

            modelBuilder.Entity("dominio.Tecnico", b =>
                {
                    b.Property<int>("Id_tecnico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("FechaN")
                        .HasColumnType("datetime2");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Sueldo")
                        .HasColumnType("float");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("VehiculoId_vehiculo")
                        .HasColumnType("int");

                    b.HasKey("Id_tecnico");

                    b.HasIndex("VehiculoId_vehiculo");

                    b.ToTable("tecnico");
                });

            modelBuilder.Entity("dominio.Vehiculo", b =>
                {
                    b.Property<int>("Id_vehiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_cliente")
                        .HasColumnType("int");

                    b.Property<int>("Id_tecnico")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Tipo_de_falla")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.HasKey("Id_vehiculo");

                    b.ToTable("vehiculo");
                });

            modelBuilder.Entity("dominio.Cliente", b =>
                {
                    b.HasOne("dominio.Vehiculo", "Vehiculo")
                        .WithMany("ClienteLista")
                        .HasForeignKey("VehiculoId_vehiculo");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("dominio.Precio", b =>
                {
                    b.HasOne("dominio.Curso", "curso")
                        .WithOne("Precio")
                        .HasForeignKey("dominio.Precio", "CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("curso");
                });

            modelBuilder.Entity("dominio.Tecnico", b =>
                {
                    b.HasOne("dominio.Vehiculo", "Vehiculo")
                        .WithMany("TecnicoLista")
                        .HasForeignKey("VehiculoId_vehiculo");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("dominio.Curso", b =>
                {
                    b.Navigation("Precio");
                });

            modelBuilder.Entity("dominio.Vehiculo", b =>
                {
                    b.Navigation("ClienteLista");

                    b.Navigation("TecnicoLista");
                });
#pragma warning restore 612, 618
        }
    }
}
