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
    public class DetallesRevisionModel : PageModel
    {
        private readonly IRepositorio_Revisiones _repo_Revision;

        public Revision Revisiones {get;set;}

        public DetallesRevisionModel(IRepositorio_Revisiones Repositorio_Revisiones){
            _repo_Revision=Repositorio_Revisiones;
        }



        public void OnGet(int id)
        {
            Revisiones=_repo_Revision.Get(id);
        }
    }
}
