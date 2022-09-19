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
    public class CrearModelRepuestos : PageModel
    {
        private readonly IRepositorio_Repuestos _repo_Repuestos;
        public Repuesto Repuesto { get; set; }

         public CrearModelRepuestos(IRepositorio_Repuestos Repositorio_Repuestos)
           {
            _repo_Repuestos = Repositorio_Repuestos;
            
           }
 

        public void OnGet()
        {
        }

         public IActionResult OnPost(Repuesto Repuesto)
        {
            _repo_Repuestos.Add(Repuesto);
            return new RedirectToPageResult("/Repuestos/listar");
        }
    }
}
