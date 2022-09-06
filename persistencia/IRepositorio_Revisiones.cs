using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorio_Revisiones
    {
        Revision Add(Revision revisiones);
        IEnumerable<Revision> GetAll();
        Revision Update(Revision revisiones);
        void Delete (int Id);
        Revision Get(Revision revisiones); 
    }
}