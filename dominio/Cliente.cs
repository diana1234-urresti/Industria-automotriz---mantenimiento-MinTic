using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace dominio
{
    public class Cliente 
       {   
        
        [Key]
        public int Id_cliente {get;set;}

        [Required(ErrorMessage = "Ingrese Nombres")]
        [StringLength(50)]
        public string Nombre {get;set;}
        [Required(ErrorMessage = "Ingrese Apellidos")]
        [StringLength(50)]
        public string Apellido{get;set;}
        public string Direccion{get;set;}
        [Required(ErrorMessage = "Ingrese Correo Electronico")]
        [StringLength(50)]
        public string Email{get;set;}
        [Required(ErrorMessage = "Ingrese Fecha de Nacimiento")]
        public DateTime FechaN{get;set;}
        [Required(ErrorMessage = "Ingrese Numero de Identificacion")] 
        [StringLength(15)]
        public string Identificacion {get;set;}
        [Required(ErrorMessage = "Ingrese Numero Telefonico")] 
        [StringLength(15)]
        public string Telefono {get;set;}

        [Required(ErrorMessage = "Ingrese Ciudad")]
        [StringLength(50)]
        public string Ciudad {get;set;}

        [Required(ErrorMessage = "Fecha de Ingreso Obligatorio")]
        
        public DateTime FechaIngreso {get;set;}

        public ICollection<Vehiculo> VehiculoLista {get;set;}
        
    }
}
