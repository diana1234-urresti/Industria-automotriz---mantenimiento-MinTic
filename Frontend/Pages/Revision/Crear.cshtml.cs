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
    public class CrearRevisionModel : PageModel
    {
        private readonly IRepositorio_Revisiones _repo_Revision;

        public Revision Revisiones {get;set;}

        public CrearRevisionModel(IRepositorio_Revisiones Repositorio_Revisiones){
            _repo_Revision=Repositorio_Revisiones;
        }


        public void OnGet()
        {
        }

         public IActionResult OnPost(Revision Revisiones)
        {
            _repo_Revision.Add(Revisiones);
            return new RedirectToPageResult("/Revision/Listar");
        }
    }
}
