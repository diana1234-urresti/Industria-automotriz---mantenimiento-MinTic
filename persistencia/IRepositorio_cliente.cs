using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public interface IRepositorio_cliente
    {
        Cliente Add(Cliente clientes);
        IEnumerable<Cliente> GetAll();
        Cliente Update (Cliente clientes);
        void Delete (int Id_cliente);
        Cliente Get(int Idcliente); 
        //IEnumerable<Vehiculo> GetAllVehiculos();
     }
}