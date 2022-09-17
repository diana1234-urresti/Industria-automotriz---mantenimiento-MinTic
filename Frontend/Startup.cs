using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using persistencia;
using Microsoft.EntityFrameworkCore;

namespace Frontend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddScoped<IRepositorio_Personas,Repositorio_Personas>();
            services.AddScoped<IRepositorio_tecnico,Repositorio_tecnicos>();
            services.AddScoped<IRepositorio_cliente,Repositorio_cliente>();
            services.AddScoped<IRepositorio_Factura,Repositorio_Factura>();
            services.AddScoped<IRepositorio_Revisiones,Repositorio_Revisiones>();
            services.AddScoped<IRepositorio_Repuestos,Repositorio_Repuestos>();
            services.AddScoped<IRepositorio_Ingreso,Repositorio_Ingreso>();
            services.AddScoped<IRepositorio_Vehiculo,Repositorio_Vehiculo>();
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(
              Configuration.GetConnectionString("DefaultConnection")
           ));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
