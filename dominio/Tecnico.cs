using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace dominio
{
    public class Tecnico
    {   
        [Key]
        public int Id_tecnico {get;set;}
                
        [Required(ErrorMessage = "Requerido el sueldo del tecnico")]
        public double Sueldo {get;set;}

        public virtual Vehiculo Vehiculo { get; set;}
        
    }
}
