using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dominio;
using persistencia;

namespace MyApp.Namespace
{
    public class listarclienteVehiculoModel : PageModel
    {
        private readonly IRepositorio_Vehiculo _repo_vehiculo;
        
        public Vehiculo vehiculo { get; set; }

        public listarclienteVehiculoModel(IRepositorio_Vehiculo Repositorio_Vehiculo)
        {
          _repo_vehiculo = Repositorio_Vehiculo;   
        }
        
       /* public void OnGetVehiculo(int id)
        {
          vehiculo = _repo_vehiculo.GetVehiculo(id);
        
        }*/
    }
}

