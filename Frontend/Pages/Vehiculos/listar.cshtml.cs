 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dominio;
using persistencia;
using Microsoft.AspNetCore.Authorization;

namespace MyApp.Namespace
{
    [Authorize]
    public class listarvehiculoModel : PageModel
    {
        private readonly IRepositorio_Vehiculo _repo_vehiculos;
        
        public IEnumerable<Vehiculo> Vehiculo { get ; set ; }
       
        public listarvehiculoModel(IRepositorio_Vehiculo Repositorio_Vehiculo)
        {
            _repo_vehiculos = Repositorio_Vehiculo;
        }

        public void OnGet()
        {
           Vehiculo = _repo_vehiculos.GetAll();
                    
        }
    }
}
