using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

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

        Cliente IRepositorio_cliente.Get(Cliente clientes){
         return _applicationContext.cliente.FirstOrDefault(p=>p.Id==clientes.Id);
         

        } 

        Cliente IRepositorio_cliente.Update(Cliente clientes){
         var ClienteEncontrado=_applicationContext.cliente.FirstOrDefault(p=>p.Id==clientes.Id);
         if (ClienteEncontrado!=null){
            ClienteEncontrado.Ciudad=clientes.Ciudad;
            ClienteEncontrado.FechaIngreso=clientes.FechaIngreso;
            ClienteEncontrado.TipoVehiculo=clientes.TipoVehiculo;
         }
         _applicationContext.SaveChanges();
         return ClienteEncontrado;
        }

        void IRepositorio_cliente.Delete (int idCliente){

        var ClienteEncontrado=_applicationContext.cliente.FirstOrDefault(p=>p.Id==idCliente);
        if (ClienteEncontrado==null)
        return;
        _applicationContext.Remove(ClienteEncontrado);
        _applicationContext.SaveChanges();
        }



       
    }
}