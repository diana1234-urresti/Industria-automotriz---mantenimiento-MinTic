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
    public class ListarFacturaModel : PageModel
    {
        private readonly IRepositorio_Factura _repo_Factura;

        public IEnumerable<Factura> Facturas {get;set;}


        public ListarFacturaModel(IRepositorio_Factura Repositorio_Factura){
            _repo_Factura=Repositorio_Factura;
        }

        public void OnGet()
        {
          Facturas=_repo_Factura.GetAll();  
        }
    }
}
