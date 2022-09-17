using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class Repositorio_Ingreso: IRepositorio_Ingreso
    {
        private readonly ApplicationContext _applicationContext;

       public Repositorio_Ingreso(ApplicationContext applicationContext){
        _applicationContext= applicationContext;
        
       }
       
       public Repositorio_Ingreso(){}
       
       Ingreso IRepositorio_Ingreso.Add(Ingreso ingresos){
        var new_ingreso=_applicationContext.ingresos.Add(ingresos);
        _applicationContext.SaveChanges();
        return new_ingreso.Entity;
       }
       

        IEnumerable<Ingreso> IRepositorio_Ingreso.GetAll(){
            return _applicationContext.ingresos;

        }

        Ingreso IRepositorio_Ingreso.Get(int Idingreso){
         return _applicationContext.ingresos.FirstOrDefault(p=>p.Id_ingreso==Idingreso);
         

        } 

        Ingreso IRepositorio_Ingreso.Update(Ingreso ingresos){
         var IngresoEncontrado=_applicationContext.ingresos.FirstOrDefault(p=>p.Id_ingreso==ingresos.Id_ingreso);
         if (IngresoEncontrado!=null){
            IngresoEncontrado.NameUsuario=ingresos.NameUsuario;
            IngresoEncontrado.Contraseña=ingresos.Contraseña;
            IngresoEncontrado.TipoUsuario=ingresos.TipoUsuario;
            
         }
         _applicationContext.SaveChanges();
         return IngresoEncontrado;
        }

        void IRepositorio_Ingreso.Delete (int idingreso){

        var IngresoEncontrado=_applicationContext.ingresos.FirstOrDefault(p=>p.Id_ingreso==idingreso);
        if (IngresoEncontrado==null)
        return;
        _applicationContext.Remove(IngresoEncontrado);
        _applicationContext.SaveChanges();
        }


    }
}