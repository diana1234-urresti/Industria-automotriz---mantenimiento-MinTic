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
    public class listartecnicoModel : PageModel
    {
        private readonly IRepositorio_tecnico _repo_tecnicos;
        
        public IEnumerable<Tecnico> Tecnicos { get ; set ; }
       
        public listartecnicoModel(IRepositorio_tecnico Repositorio_tecnicos)
        {
            _repo_tecnicos = Repositorio_tecnicos;
        }

        public void OnGet()
        {
           Tecnicos = _repo_tecnicos.GetAll();
                    
        }
    }
}
