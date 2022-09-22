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
    public class listarModelRespuestos : PageModel
    {
        private readonly IRepositorio_Repuestos _repo_Repuestos;
        
        public IEnumerable<Repuesto> Repuesto { get ; set ; }
       
        public listarModelRespuestos(IRepositorio_Repuestos Repositorio_Repuestos)
        {
            _repo_Repuestos = Repositorio_Repuestos;
        }

        public void OnGet()
        {
           Repuesto = _repo_Repuestos.GetAll();
                    
        }
    }
}
