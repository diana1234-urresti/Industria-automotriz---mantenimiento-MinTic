using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;
using Microsoft.EntityFrameworkCore;

namespace persistencia
{
    public class Repositorio_cliente: IRepositorio_cliente
    {
       private readonly ApplicationContext _applicationContext;

       public Repositorio_cliente(ApplicationContext applicationContext){
        _applicationContext= applicationContext;
        
       }
       
       public Repositorio_cliente(){}
       
       Cliente IRepositorio_cliente.Add(Cliente clientes){
        var new_cliente=_applicationContext.cliente.Add(clientes);
        _applicationContext.SaveChanges();
        return new_cliente.Entity;
       }
       

        IEnumerable<Cliente> IRepositorio_cliente.GetAll(){
            return _applicationContext.cliente;

        }


        Cliente IRepositorio_cliente.Get(int Idcliente){
         return _applicationContext.cliente.FirstOrDefault(p=>p.Id_cliente==Idcliente);
        } 

        
        Cliente IRepositorio_cliente.Update(Cliente clientes){
         var ClienteEncontrado=_applicationContext.cliente.FirstOrDefault(p=>p.Id_cliente==clientes.Id_cliente);
         if (ClienteEncontrado!=null){
            ClienteEncontrado.Nombre=clientes.Nombre;
            ClienteEncontrado.Apellido=clientes.Apellido;
            ClienteEncontrado.Direccion=clientes.Direccion;
            ClienteEncontrado.Email=clientes.Email;
            ClienteEncontrado.Identificacion=clientes.Identificacion;
            ClienteEncontrado.FechaN=clientes.FechaN;
            ClienteEncontrado.Telefono=clientes.Telefono;
            ClienteEncontrado.Ciudad=clientes.Ciudad;
            ClienteEncontrado.FechaIngreso=clientes.FechaIngreso;
             }
         _applicationContext.SaveChanges();
         return ClienteEncontrado;
        }

        void IRepositorio_cliente.Delete (int idCliente){

        var ClienteEncontrado=_applicationContext.cliente.FirstOrDefault(p=>p.Id_cliente==idCliente);
        if (ClienteEncontrado==null)
        return;
        _applicationContext.Remove(ClienteEncontrado);
        _applicationContext.SaveChanges();
        }
         

      //  IEnumerable<Vehiculo> IRepositorio_cliente.GetAllVehiculos(){
      //  return _applicationContext.cliente.Include(c => c.VehiculoLista);
      //   }


       
    }
}