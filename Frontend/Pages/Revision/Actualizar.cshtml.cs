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
    public class ActualizarRevisionModel : PageModel
    {   
        private readonly IRepositorio_Revisiones _repo_Revision;

        public Revision Revisiones {get;set;}

        public ActualizarRevisionModel(IRepositorio_Revisiones Repositorio_Revisiones){
            _repo_Revision=Repositorio_Revisiones;
        }


        public void OnGet(int id)
        {
            
            Revisiones=_repo_Revision.Get(id);
        }

        public IActionResult OnPost(Revision Revisiones)
        {
             if(!ModelState.IsValid)
              return Page();
             
              _repo_Revision.Update(Revisiones);
               return new RedirectToPageResult("Listar");
            
        }

        
    }
}
