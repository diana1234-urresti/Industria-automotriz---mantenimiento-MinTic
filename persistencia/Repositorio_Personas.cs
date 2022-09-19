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

        Persona IRepositorio_Personas.Get(int Idpersona){
         return _applicationContext.persona.FirstOrDefault(
            p => p.Id_persona == Idpersona );         
        } 

        Persona IRepositorio_Personas.Update(Persona persona){
         var PersonaEncontrada = _applicationContext.persona.FirstOrDefault(
            p => p.Id_persona == persona.Id_persona);
         if (PersonaEncontrada != null){
            PersonaEncontrada.Nombre=persona.Nombre;
            PersonaEncontrada.Apellido=persona.Apellido;
            PersonaEncontrada.Direccion=persona.Direccion;
            PersonaEncontrada.Email=persona.Email;
            PersonaEncontrada.Identificacion=persona.Identificacion;
            PersonaEncontrada.FechaN=persona.FechaN;
            PersonaEncontrada.Telefono=persona.Telefono;
         }
         _applicationContext.SaveChanges();
         return PersonaEncontrada;
        }

        void IRepositorio_Personas.Delete(int Idpersona){

        var PersonaEncontrada=_applicationContext.persona.FirstOrDefault(
            p => p.Id_persona ==  Idpersona);
        if (PersonaEncontrada == null)
        return;
        _applicationContext.Remove(PersonaEncontrada);
        _applicationContext.SaveChanges();
        }



       
    }
}