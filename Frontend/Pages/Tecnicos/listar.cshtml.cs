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
    public class listarModeltecnicos : PageModel
    {

    private readonly IRepositorio_tecnico _repo_tecnico;
        public IEnumerable<Tecnico> tecnicos { get ; set ; }
       
        public listarModeltecnicos(IRepositorio_tecnico Repositorio_tecnicos)
        {
            _repo_tecnico = Repositorio_tecnicos;
        }
        public void OnGet()
        {
            tecnicos = _repo_tecnico.GetAll();
           foreach (var tecnico in tecnicos)
           {
              Console.WriteLine(tecnico.Sueldo);   
           }
        }
    }
}
