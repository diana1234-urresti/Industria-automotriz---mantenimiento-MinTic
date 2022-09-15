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
    public class CrearvehiculoModel : PageModel
    {
        private readonly IRepositorio_Vehiculo _repo_vehiculos;
        public Vehiculo vehiculo { get; set; }

         public CrearvehiculoModel(IRepositorio_Vehiculo Repositorio_Vehiculo)
           {
            _repo_vehiculos = Repositorio_Vehiculo;
            
           }
 

        public void OnGet()
        {
        }

         public IActionResult OnPost(Vehiculo vehiculo)
         {
            if(!ModelState.IsValid)
             return Page();

            _repo_vehiculos.Add(vehiculo);
            return new RedirectToPageResult("/Vehiculos/listar");
         }
    }
}
