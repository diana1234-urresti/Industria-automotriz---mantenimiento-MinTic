using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class Repositorio_Factura: IRepositorio_Factura
    {
       private readonly ApplicationContext _applicationContext;

       public Repositorio_Factura(ApplicationContext applicationContext){
        _applicationContext= applicationContext;
        
       }
       
       public Repositorio_Factura(){}
       
       Factura IRepositorio_Factura.Add(Factura factura){
        var new_factura=_applicationContext.factura.Add(factura);
        _applicationContext.SaveChanges();
        return new_factura.Entity;
       }
       

        IEnumerable<Factura> IRepositorio_Factura.GetAll(){
            return _applicationContext.factura;

        }

        Factura IRepositorio_Factura.Get(int Idfactura){
         return _applicationContext.factura.FirstOrDefault(p=>p.Id_factura==Idfactura);
         

        } 

        Factura IRepositorio_Factura.Update(Factura factura){
         var FacturaEncontrada=_applicationContext.factura.FirstOrDefault(p=>p.Id_factura==factura.Id_factura);
         if (FacturaEncontrada!=null){
            FacturaEncontrada.FechaFacturacion=factura.FechaFacturacion;
            FacturaEncontrada.CostoRevision=factura.CostoRevision;
            FacturaEncontrada.CostoRepuesto=factura.CostoRepuesto;
            FacturaEncontrada.Iva=factura.Iva;
            FacturaEncontrada.Total=factura.Total;
         }
         _applicationContext.SaveChanges();
         return FacturaEncontrada;
        }

        void IRepositorio_Factura.Delete (int idfactura){

        var FacturaEncontrada=_applicationContext.factura.FirstOrDefault(p=>p.Id_factura==idfactura);
        if (FacturaEncontrada==null)
        return;
        _applicationContext.Remove(FacturaEncontrada);
        _applicationContext.SaveChanges();
        }



       
    }
}