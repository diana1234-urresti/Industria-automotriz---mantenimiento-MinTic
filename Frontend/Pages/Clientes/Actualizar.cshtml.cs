using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using persistencia;
using dominio;

namespace MyApp.Namespace
{
    public class ActualizarclienteModel : PageModel
    {
         private readonly IRepositorio_cliente _repo_clientes;
        
        public Cliente Clientes { get; set; }

        public ActualizarclienteModel(IRepositorio_cliente Repositorio_cliente)
        {
          _repo_clientes = Repositorio_cliente;   
        }
        
        public void OnGet(int id)
        {
          Clientes = _repo_clientes.Get(id);
        }

         public IActionResult OnPost(Cliente Clientes)
        {
              _repo_clientes.Update(Clientes);
               return new RedirectToPageResult("listar");
            
        }
    }
}
