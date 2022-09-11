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
    public class ListarRevisionModel : PageModel
    {
        private readonly IRepositorio_Revisiones _repo_Revision;

        public IEnumerable<Revision> Revision {get;set;}


        public ListarRevisionModel(IRepositorio_Revisiones Repositorio_Revisiones){
            _repo_Revision=Repositorio_Revisiones;
        }

        public void OnGet()
        {
           Revision=_repo_Revision.GetAll();  
        }
    }
}
