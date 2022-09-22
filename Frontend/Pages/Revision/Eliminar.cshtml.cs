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
    public class EliminarRevisionModel : PageModel
    {
        private readonly IRepositorio_Revisiones _repo_Revision;

        public Revision Revisiones {get;set;}

        public EliminarRevisionModel(IRepositorio_Revisiones Repositorio_Revisiones){
            _repo_Revision=Repositorio_Revisiones;
        }


        public void OnGet(int id)
        {
            Revisiones=_repo_Revision.Get(id);
        }

        public IActionResult OnPost(int id)
        {
              _repo_Revision.Delete(id);
               return new RedirectToPageResult("Listar");
        }



    }
}
