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
    public class listarModel : PageModel
    {
        private readonly IRepositorio_Personas _repo_personas;
        public IEnumerable<Persona> Personas { get ; set ; }
       
        public listarModel(IRepositorio_Personas Repositorio_Personas)
        {
            _repo_personas = Repositorio_Personas;
        }

        public void OnGet()
        {
           Personas = _repo_personas.GetAll();
           foreach (var persona in Personas)
           {
              Console.WriteLine(persona.Nombre);   
           }
          
        }
    }
}
