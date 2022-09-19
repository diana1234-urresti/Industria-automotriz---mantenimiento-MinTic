using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorio_Personas
    {
        Persona Add(Persona persona);
        IEnumerable<Persona> GetAll();
        Persona Update(Persona persona);
        void Delete (int Id_persona);
        Persona Get(int Idpersona); 
    }
}