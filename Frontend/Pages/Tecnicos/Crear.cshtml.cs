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
    public class CreartecnicoModel : PageModel
    {
        private readonly IRepositorio_tecnico _repo_tecnicos;
        public Tecnico Tecnicos { get; set; }

         public CreartecnicoModel(IRepositorio_tecnico Repositorio_tecnicos)
           {
            _repo_tecnicos = Repositorio_tecnicos;
            
           }
 

        public void OnGet()
        {
        }

         public IActionResult OnPost(Tecnico Tecnicos)
        {
             if(!ModelState.IsValid)
              return Page();
            
            _repo_tecnicos.Add(Tecnicos);
            return new RedirectToPageResult("/Tecnicos/listar");
        }
    }
}
