using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dominio;
using persistencia;

#pragma warning restore format

namespace MyApp.Namespace
{
    public class EliminarclienteModel : PageModel
    {
        private readonly IRepositorio_cliente _repo_clientes;
        
        public Cliente Clientes { get; set; }

        public EliminarclienteModel(IRepositorio_cliente Repositorio_cliente)
        {
          _repo_clientes = Repositorio_cliente;   
        }
        
        public void OnGet(int id)
        {
          Clientes = _repo_clientes.Get(id);
        }

        public IActionResult OnPost(int id)
        {
              _repo_clientes.Delete(id);
               return new RedirectToPageResult("listar");
        }
    }
}
