using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace dominio
{
    public class Ingreso
    {
        [Key]
        public int Id{get;set;}

        [Required(ErrorMessage="Ingrese el nombre de usuario")]
        public string NameUsuario {get;set;}

        [Required(ErrorMessage="Ingrese la contraseña")]
        public string Contraseña {get;set;}

        [Required(ErrorMessage="Ingrese el tipo de usuario")]
        public string TipoUsuario {get;set;}
        
    }
}
