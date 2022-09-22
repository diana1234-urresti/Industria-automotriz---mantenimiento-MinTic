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
    public class listarclienteModel : PageModel
    {
        private readonly IRepositorio_cliente _repo_clientes;
        
        public IEnumerable<Cliente> Clientes { get ; set ; }
       
        public listarclienteModel(IRepositorio_cliente Repositorio_cliente)
        {
            _repo_clientes = Repositorio_cliente;
        }

        public void OnGet()
        {
           Clientes = _repo_clientes.GetAll();
                    
        }
    }
}
