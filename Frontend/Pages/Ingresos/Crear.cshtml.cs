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
    public class CrearIngresoModel : PageModel
    {
        private readonly IRepositorio_Ingreso _repo_Ingreso;

        public Ingreso Ingresos {get;set;}

        public CrearIngresoModel(IRepositorio_Ingreso Repositorio_Ingreso){
            _repo_Ingreso=Repositorio_Ingreso;
        }


        public void OnGet()
        {
        }

         public IActionResult OnPost(Ingreso Ingresos)
        {
             if(!ModelState.IsValid)
             return Page();
             
            _repo_Ingreso.Add(Ingresos);
            return new RedirectToPageResult("/Ingresos/Listar");
        }
    }
}
