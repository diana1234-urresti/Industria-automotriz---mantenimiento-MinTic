using System;
using System.ComponentModel.DataAnnotations;

namespace dominio
{
    public class Cliente
    {
        public int Id {get;set;}
        [Required(ErrorMessage = "Ingrese Ciudad")]
        [StringLength(50)]
        public string Ciudad {get;set;}
        [Required(ErrorMessage = "Fecha de Ingreso Obligatorio")]
        [StringLength(50)]
        public DateTime FechaIngreso {get;set;}
        [Required(ErrorMessage = "Ingrese Tipo de Vehiculo")]
        [StringLength(50)]
        public string TipoVehiculo {get;set;}
        
    }
}
