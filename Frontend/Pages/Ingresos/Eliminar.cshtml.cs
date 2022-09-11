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
    public class EliminarIngresoModel : PageModel
    {
        private readonly IRepositorio_Ingreso _repo_Ingreso;

        public Ingreso Ingresos {get;set;}


        public EliminarIngresoModel(IRepositorio_Ingreso Repositorio_Ingreso){
            _repo_Ingreso=Repositorio_Ingreso;
        }

        public void OnGet(int id)
        {
            Ingresos=_repo_Ingreso.Get(id);
        }

        public IActionResult OnPost(int id)
        {
              _repo_Ingreso.Delete(id);
               return new RedirectToPageResult("Listar");
        }



    }
}
