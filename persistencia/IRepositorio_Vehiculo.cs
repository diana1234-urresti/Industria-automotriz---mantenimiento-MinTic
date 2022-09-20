using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;
using Microsoft.EntityFrameworkCore;

namespace persistencia
{
    public interface IRepositorio_Vehiculo
    {
        Vehiculo Add(Vehiculo vehiculo);
        IEnumerable<Vehiculo> GetAll();
        Vehiculo Update(Vehiculo vehiculo);
        void Delete (int Id_vehiculo);
        Vehiculo Get(int vehiculo); 
       // IEnumerable<Vehiculo> GetVehiculo(int Idcliente);

    }
}