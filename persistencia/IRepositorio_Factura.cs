using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorio_Factura
    {
        Factura Add(Factura facturas);
        IEnumerable<Factura> GetAll();
        Factura Update (Factura facturas);
        void Delete (int Id);
        Factura Get(int Id); 
    }
}