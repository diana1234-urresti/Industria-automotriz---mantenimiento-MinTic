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
    public class listarModelclientes : PageModel
    {

    private readonly IRepositorio_cliente _repo_cliente;
        public IEnumerable<Cliente> Clientes { get ; set ; }
       
        public listarModelclientes(IRepositorio_cliente Repositorio_cliente)
        {
            _repo_cliente = Repositorio_cliente;
        }
        public void OnGet()
        {
            Clientes = _repo_cliente.GetAll();
           foreach (var cliente in Clientes)
           {
              Console.WriteLine(cliente.Ciudad);   
           }
        }
    }
}
