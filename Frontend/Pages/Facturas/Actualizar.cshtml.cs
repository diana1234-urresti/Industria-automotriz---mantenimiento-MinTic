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
    public class ActualizarFacturaModel : PageModel
    {
        private readonly IRepositorio_Factura _repo_Factura;

        public Factura Facturas {get;set;}


        public ActualizarFacturaModel(IRepositorio_Factura Repositorio_Factura){
            _repo_Factura=Repositorio_Factura;
        }


        public void OnGet(int id)
        {
            
            Facturas=_repo_Factura.Get(id);
        }

        public IActionResult OnPost(Factura Facturas)
        {
              _repo_Factura.Update(Facturas);
               return new RedirectToPageResult("Listar");
            
        }

        
    }
}
