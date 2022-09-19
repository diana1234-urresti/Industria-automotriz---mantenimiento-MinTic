using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace dominio
{
    public class Tecnico
    {   
        [Key]
        public int Id_tecnico {get;set;}

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
                
        [Required(ErrorMessage = "Requerido el sueldo del tecnico")]
        public double Sueldo {get;set;}

        public ICollection<Vehiculo> VehiculoLista {get;set;}
        
    }
}
