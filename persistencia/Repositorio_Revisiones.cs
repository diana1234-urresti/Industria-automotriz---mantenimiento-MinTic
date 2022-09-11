using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class Repositorio_Revisiones: IRepositorio_Revisiones
    {
       private readonly ApplicationContext _applicationContext;

       public Repositorio_Revisiones(ApplicationContext applicationContext){
        _applicationContext= applicationContext;
        
       }
       
       public Repositorio_Revisiones(){}
       
       Revision IRepositorio_Revisiones.Add(Revision revisiones){
        var new_revision=_applicationContext.revision.Add(revisiones);
        _applicationContext.SaveChanges();
        return new_revision.Entity;
       }
       

        IEnumerable<Revision> IRepositorio_Revisiones.GetAll(){
            return _applicationContext.revision;

        }

        Revision IRepositorio_Revisiones.Get(int IdRevision){
         return _applicationContext.revision.FirstOrDefault(p=>p.Id==IdRevision);
         

        } 

        Revision IRepositorio_Revisiones.Update(Revision revisiones){
         var RevisionEncontrada=_applicationContext.revision.FirstOrDefault(p=>p.Id==revisiones.Id);
         if (RevisionEncontrada!=null){
            RevisionEncontrada.NoRevision=revisiones.NoRevision;
            RevisionEncontrada.NoPlaca=revisiones.NoPlaca;
            RevisionEncontrada.TipoMantenimiento=revisiones.TipoMantenimiento;
            RevisionEncontrada.FechaRevision=revisiones.FechaRevision;
            RevisionEncontrada.EstadoFiltro=revisiones.EstadoFiltro;
            RevisionEncontrada.Repuesto=revisiones.Repuesto;
            RevisionEncontrada.EstadoAceite=revisiones.EstadoAceite;
         }
         _applicationContext.SaveChanges();
         return RevisionEncontrada;
        }

        void IRepositorio_Revisiones.Delete (int idrevision){

        var RevisionEncontrada=_applicationContext.revision.FirstOrDefault(p=>p.Id==idrevision);
        if (RevisionEncontrada==null)
        return;
        _applicationContext.Remove(RevisionEncontrada);
        _applicationContext.SaveChanges();
        }
       
    }
}