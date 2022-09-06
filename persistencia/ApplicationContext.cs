﻿using System;
using dominio;
using Microsoft.EntityFrameworkCore;

namespace persistencia
{
    public class ApplicationContext: DbContext
    {
        private const string connectionString = @"Data Source=localhost;Initial Catalog=Mantenimiento_Tic;Integrated Security=True;";
        public DbSet<Cliente> cliente {get; set;}
        public DbSet<Factura> factura {get; set;}
        public DbSet<Ingreso> ingreso {get; set;}
        public DbSet<Persona> persona {get; set;}
        public DbSet<Repuesto> repuesto {get; set;}
        public DbSet<Revision> revision {get; set;}
        public DbSet<Tecnico> tecnico {get; set;}

        public ApplicationContext(){}

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        :base(options)
    {
    }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }

    }
}
 