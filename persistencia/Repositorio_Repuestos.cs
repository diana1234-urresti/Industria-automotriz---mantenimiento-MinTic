using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class Repositorio_Repuestos: IRepositorio_Repuestos
    {
       private readonly ApplicationContext _applicationContext;

       public Repositorio_Repuestos(ApplicationContext applicationContext){
        _applicationContext= applicationContext;
        
       }
       
       public Repositorio_Repuestos(){}
       
       Repuesto IRepositorio_Repuestos.Add(Repuesto repuesto){
        var new_repuesto=_applicationContext.repuesto.Add(repuesto);
        _applicationContext.SaveChanges();
        return new_repuesto.Entity;
       }
       

        IEnumerable<Repuesto> IRepositorio_Repuestos.GetAll(){
            return _applicationContext.repuesto;

        }

        Repuesto IRepositorio_Repuestos.Get(int IdRepuesto){
         return _applicationContext.repuesto.FirstOrDefault(p=>p.Id==IdRepuesto);
         

        } 

       Repuesto IRepositorio_Repuestos.Update(Repuesto repuesto){
        var RepuestoEncontrado=_applicationContext.repuesto.FirstOrDefault(p=>p.Id==repuesto.Id);
         if (RepuestoEncontrado!=null){
            RepuestoEncontrado.Valor=repuesto.Valor;
            RepuestoEncontrado.NombreParte=repuesto.NombreParte;
            
         }
         _applicationContext.SaveChanges();
         return RepuestoEncontrado;
        }

        void IRepositorio_Repuestos.Delete (int idRepuesto){

        var RepuestoEncontrado=_applicationContext.repuesto.FirstOrDefault(p=>p.Id==idRepuesto);
        if (RepuestoEncontrado==null)
        return;
        _applicationContext.Remove(RepuestoEncontrado);
        _applicationContext.SaveChanges();
        }



       
    }
}
