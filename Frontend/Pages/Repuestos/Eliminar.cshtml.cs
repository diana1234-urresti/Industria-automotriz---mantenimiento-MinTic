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
    public class EliminarModelRepuestos : PageModel
{
        private readonly IRepositorio_Repuestos _repo_Repuestos;
        
        public Repuesto Repuesto { get; set; }

        public EliminarModelRepuestos(IRepositorio_Repuestos Repositorio_Repuestos)
        {
          _repo_Repuestos = Repositorio_Repuestos;   
        }
        
        public void OnGet(int id)
        {
          Repuesto = _repo_Repuestos.Get(id);
        }

        public IActionResult OnPost(int id)
        {
              _repo_Repuestos.Delete(id);
               return new RedirectToPageResult("listar");
        }
    }




}
