using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using persistencia;
using dominio;

namespace MyApp.Namespace
{
    public class ActualizarVehiculoModel : PageModel
    {
         private readonly IRepositorio_Vehiculo _repo_vehiculos;
        
        public Vehiculo vehiculo { get; set; }

        public ActualizarVehiculoModel(IRepositorio_Vehiculo Repositorio_Vehiculo)
        {
          _repo_vehiculos = Repositorio_Vehiculo;   
        }
        
        public void OnGet(int id)
        {
          vehiculo = _repo_vehiculos.Get(id);
        }

         public IActionResult OnPost(Vehiculo vehiculo)
        {

           if(!ModelState.IsValid)
             return Page();
             
              _repo_vehiculos.Update(vehiculo);
               return new RedirectToPageResult("listar");
            
        }
    }
}
