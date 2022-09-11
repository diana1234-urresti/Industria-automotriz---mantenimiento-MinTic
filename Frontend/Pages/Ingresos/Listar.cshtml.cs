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
    public class ListarIngresoModel : PageModel
    {
        private readonly IRepositorio_Ingreso _repo_Ingreso;

        public IEnumerable<Ingreso> Ingresos {get;set;}


        public ListarIngresoModel(IRepositorio_Ingreso Repositorio_Ingreso){
            _repo_Ingreso=Repositorio_Ingreso;
        }

        public void OnGet()
        {
          Ingresos=_repo_Ingreso.GetAll();  
        }
    }
}
