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
         return _applicationContext.tecnico.FirstOrDefault(p=>p.Id_tecnico==Idtecnico);
         

        } 

          Tecnico IRepositorio_tecnico.Update(Tecnico tecnicos){
         var TecnicoEncontrado = _applicationContext.tecnico.FirstOrDefault(
            p => p.Id_tecnico == tecnicos.Id_tecnico);
         if (TecnicoEncontrado != null){
            TecnicoEncontrado.Nombre=tecnicos.Nombre;
            TecnicoEncontrado.Apellido=tecnicos.Apellido;
            TecnicoEncontrado.Email=tecnicos.Email;
            TecnicoEncontrado.FechaN=tecnicos.FechaN;
            TecnicoEncontrado.Identificacion=tecnicos.Identificacion;
            TecnicoEncontrado.Telefono=tecnicos.Telefono;
            TecnicoEncontrado.Sueldo=tecnicos.Sueldo;
              }
         _applicationContext.SaveChanges();
         return TecnicoEncontrado;
        }
 

        void IRepositorio_tecnico.Delete (int idtecnico){

        var tecnicoEncontrado=_applicationContext.tecnico.FirstOrDefault(p=>p.Id_tecnico==idtecnico);
        if (tecnicoEncontrado==null)
        return;
        _applicationContext.Remove(tecnicoEncontrado);
        _applicationContext.SaveChanges();
        }



       
    }
}