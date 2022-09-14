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
    public class CrearModel : PageModel
    {
        private readonly IRepositorio_Personas _repo_personas;
        public Persona Personas { get; set; }

         public CrearModel(IRepositorio_Personas Repositorio_Personas)
           {
            _repo_personas = Repositorio_Personas;
            
           }
 

        public void OnGet()
        {
        }

         public IActionResult OnPost(Persona Personas)
         {
            if(!ModelState.IsValid)
             return Page();

            _repo_personas.Add(Personas);
            return new RedirectToPageResult("/Personas/listar");
         }
    }
}
