using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorio_Ingreso
    {
        Ingreso Add (Ingreso ingresos);
        IEnumerable<Ingreso> GetAll();
        Ingreso Update (Ingreso Ingresos);
        void Delete (int Id);
        Ingreso Get(int Id);

    }
}