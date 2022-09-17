using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorio_Repuestos
    {
        Repuesto Add(Repuesto repuesto);
        IEnumerable<Repuesto> GetAll();
       Repuesto Update (Repuesto repuestos);
        void Delete (int Id);
        Repuesto Get(int IdRepuesto); 
    }
}
