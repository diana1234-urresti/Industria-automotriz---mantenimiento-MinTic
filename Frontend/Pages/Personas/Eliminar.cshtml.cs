using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dominio;
using persistencia;

#pragma warning restore format

namespace MyApp.Namespace
{
    public class EliminarModel : PageModel
    {
        private readonly IRepositorio_Personas _repo_personas;
        
        public Persona Personas { get; set; }

        public EliminarModel(IRepositorio_Personas Repositorio_Personas)
        {
          _repo_personas = Repositorio_Personas;   
        }
        
        public void OnGet(int id)
        {
          Personas = _repo_personas.Get(id);
        }

        public IActionResult OnPost(int id)
        {
              _repo_personas.Delete(id);
               return new RedirectToPageResult("listar");
        }
    }
}
