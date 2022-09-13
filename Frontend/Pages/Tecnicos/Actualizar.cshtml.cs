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
    public class ActualizartecnicoModel : PageModel
    {
         private readonly IRepositorio_tecnico _repo_tecnicos;
        
        public Tecnico Tecnicos { get; set; }

        public ActualizartecnicoModel(IRepositorio_tecnico Repositorio_tecnicos)
        {
          _repo_tecnicos = Repositorio_tecnicos;   
        }
        
        public void OnGet(int id)
        {
          Tecnicos = _repo_tecnicos.Get(id);
        }

      //   public IActionResult OnPost(Tecnico Tecnicos)
      //  {
      //        _repo_tecnicos.Update(Tecnicos);
       //        return new RedirectToPageResult("listar");
            
       // }
    }
}
