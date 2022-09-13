using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class Repositorio_tecnicos: IRepositorio_tecnico
    {
       private readonly ApplicationContext _applicationContext;

       public Repositorio_tecnicos(ApplicationContext applicationContext){
        _applicationContext= applicationContext;
        
       }
       
       public Repositorio_tecnicos(){}
       
       Tecnico IRepositorio_tecnico.Add(Tecnico tecnicos){
        var new_tecnico=_applicationContext.tecnico.Add(tecnicos);
        _applicationContext.SaveChanges();
        return new_tecnico.Entity;
       }
       

        IEnumerable<Tecnico> IRepositorio_tecnico.GetAll(){
            return _applicationContext.tecnico;

        }

        Tecnico IRepositorio_tecnico.Get(int Idtecnico){
         return _applicationContext.tecnico.FirstOrDefault(p=>p.Id==Idtecnico);
         

        } 

      /* Tecnico IRepositorio_tecnico.Update(Tecnico tecnicos){
        var tecnicoEncontrado=_applicationContext.tecnico.FirstOrDefault(p=>p.Id==tecnicos.Id);
        if (tecnicoEncontrado!=null){
           tecnicoEncontrado.sueldo=tecnicos.sueldo;
                   
         _applicationContext.SaveChanges();
         return tecnicoEncontrado;
        }  }*/

        void IRepositorio_tecnico.Delete (int idtecnico){

        var tecnicoEncontrado=_applicationContext.tecnico.FirstOrDefault(p=>p.Id==idtecnico);
        if (tecnicoEncontrado==null)
        return;
        _applicationContext.Remove(tecnicoEncontrado);
        _applicationContext.SaveChanges();
        }



       
    }
}