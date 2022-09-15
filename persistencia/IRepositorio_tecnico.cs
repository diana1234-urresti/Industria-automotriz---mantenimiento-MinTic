using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorio_tecnico
    {
        Tecnico Add(Tecnico tecnicos);
        IEnumerable<Tecnico> GetAll();
        Tecnico Update (Tecnico tecnicos);
        void Delete (int Id_tecnico);
        Tecnico Get(int Idtecnico); 
    }
}