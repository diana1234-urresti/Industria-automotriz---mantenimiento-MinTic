using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dominio;

namespace persistencia
{
    public class Repositorio_Personas: IRepositorio_Personas
    {
       private readonly ApplicationContext _applicationContext;

       public Repositorio_Personas(ApplicationContext applicationContext){
        _applicationContext= applicationContext;
        
       }
       
       public Repositorio_Personas(){}
       
       Persona IRepositorio_Personas.Add(Persona persona){
        var new_persona=_applicationContext.persona.Add(persona);
        _applicationContext.SaveChanges();
        return new_persona.Entity;
       }
       

        IEnumerable<Persona> IRepositorio_Personas.GetAll(){
            return _applicationContext.persona;

        }

        Persona IRepositorio_Personas.Get(Persona persona){
         return _applicationContext.persona.FirstOrDefault(p=>p.Id==persona.Id);
         

        } 

        Persona IRepositorio_Personas.Update(Persona persona){
         var PersonaEncontrada=_applicationContext.persona.FirstOrDefault(p=>p.Id==persona.Id);
         if (PersonaEncontrada!=null){
            PersonaEncontrada.Nombre=persona.Nombre;
         }
         _applicationContext.SaveChanges();
         return PersonaEncontrada;
        }

        void IRepositorio_Personas.Delete (int idPersona){

        var PersonaEncontrada=_applicationContext.persona.FirstOrDefault(p=>p.Id==idPersona);
        if (PersonaEncontrada==null)
        return;
        _applicationContext.Remove(PersonaEncontrada);
        _applicationContext.SaveChanges();
        }



       
    }
}