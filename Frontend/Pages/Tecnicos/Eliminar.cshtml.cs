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
    public class EliminartecnicoModel : PageModel
    {
        private readonly IRepositorio_tecnico _repo_tecnicos;
        
        public Tecnico Tecnicos { get; set; }

        public EliminartecnicoModel(IRepositorio_tecnico Repositorio_tecnicos)
        {
          _repo_tecnicos = Repositorio_tecnicos;   
        }
        
        public void OnGet(int id)
        {
          Tecnicos = _repo_tecnicos.Get(id);
        }

        public IActionResult OnPost(int id)
        {
              _repo_tecnicos.Delete(id);
               return new RedirectToPageResult("listar");
        }
    }
}
