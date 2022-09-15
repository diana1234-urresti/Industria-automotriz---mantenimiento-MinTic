using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace dominio
{
    public class Cliente
    {   
        
        [Key]
        public int Id_cliente {get;set;}

        [Required(ErrorMessage = "Ingrese Ciudad")]
        [StringLength(50)]
        public string Ciudad {get;set;}

        [Required(ErrorMessage = "Fecha de Ingreso Obligatorio")]
        public DateTime FechaIngreso {get;set;}

        public virtual Vehiculo Vehiculo { get; set;}
        
    }
}
