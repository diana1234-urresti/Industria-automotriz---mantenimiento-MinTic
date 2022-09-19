using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;
using Microsoft.EntityFrameworkCore;

namespace persistencia
{
    public class Repositorio_Vehiculo: IRepositorio_Vehiculo
    {
       private readonly ApplicationContext _applicationContext;

       public Repositorio_Vehiculo(ApplicationContext applicationContext){
        _applicationContext= applicationContext;
       }
       
       public Repositorio_Vehiculo(){}
       
       Vehiculo IRepositorio_Vehiculo.Add(Vehiculo vehiculo){
        var new_vehiculo=_applicationContext.vehiculo.Add(vehiculo);
        _applicationContext.SaveChanges();
        return new_vehiculo.Entity;
       }
       

        IEnumerable<Vehiculo> IRepositorio_Vehiculo.GetAll(){
            return _applicationContext.vehiculo;
        }

        Vehiculo IRepositorio_Vehiculo.Get(int Idvehiculo){
         return _applicationContext.vehiculo.FirstOrDefault(
            p => p.Id_vehiculo == Idvehiculo );         
        } 

        Vehiculo IRepositorio_Vehiculo.Update(Vehiculo vehiculo){
         var vehiculoEncontrado = _applicationContext.vehiculo.FirstOrDefault(
            p => p.Id_vehiculo == vehiculo.Id_vehiculo);
         if (vehiculoEncontrado != null){
            vehiculoEncontrado.Tipo=vehiculo.Tipo;
            vehiculoEncontrado.Matricula=vehiculo.Matricula;
            vehiculoEncontrado.Modelo=vehiculo.Modelo;
            vehiculoEncontrado.Marca=vehiculo.Marca;
            vehiculoEncontrado.FechaIngreso=vehiculo.FechaIngreso;
            vehiculoEncontrado.Tipo_de_falla=vehiculo.Tipo_de_falla;
             }
         _applicationContext.SaveChanges();
         return vehiculoEncontrado;
        }

        void IRepositorio_Vehiculo.Delete(int Idvehiculo){

        var vehiculoEncontrado=_applicationContext.vehiculo.FirstOrDefault(
            p => p.Id_vehiculo ==  Idvehiculo);
        if (vehiculoEncontrado == null)
        return;
        _applicationContext.Remove(vehiculoEncontrado);
        _applicationContext.SaveChanges();
        }

       IEnumerable<Vehiculo> IRepositorio_Vehiculo.GetAllVehiculos(){
        return _applicationContext.vehiculo.Include(c => c.clientes);

        }

       //IEnumerable<Vehiculo> IRepositorio_Vehiculo.GetVehiculo(int Idcliente){
       //  return _applicationContext.vehiculo(p => p.Id_cliente == Idcliente );         
       // } 

      
          
    }
}