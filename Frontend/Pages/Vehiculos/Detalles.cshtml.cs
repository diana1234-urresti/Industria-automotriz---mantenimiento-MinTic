using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dominio;
using persistencia;

namespace MyApp.Namespace
{
    public class DetallesvehiculoModel : PageModel
    {
         private readonly IRepositorio_Vehiculo _repo_vehiculos;
        
        public Vehiculo vehiculo { get; set; }

        public DetallesvehiculoModel(IRepositorio_Vehiculo Repositorio_Vehiculo)
        {
          _repo_vehiculos = Repositorio_Vehiculo;   
        }
        
        public void OnGet(int id)
        {
          vehiculo = _repo_vehiculos.Get(id);
        }
    }
}
