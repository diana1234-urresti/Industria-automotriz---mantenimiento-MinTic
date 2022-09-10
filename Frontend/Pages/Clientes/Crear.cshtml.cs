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
    public class CrearclienteModel : PageModel
    {
        private readonly IRepositorio_cliente _repo_clientes;
        public Cliente Clientes { get; set; }

         public CrearclienteModel(IRepositorio_cliente Repositorio_Cliente)
           {
            _repo_clientes = Repositorio_Cliente;
            
           }
 

        public void OnGet()
        {
        }

         public IActionResult OnPost(Cliente Clientes)
        {
            _repo_clientes.Add(Clientes);
            return new RedirectToPageResult("/Clientes/listar");
        }
    }
}
