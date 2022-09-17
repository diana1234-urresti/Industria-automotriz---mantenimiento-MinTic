using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace dominio
{
    public class Vehiculo
    {
        [Key]
        public int Id_vehiculo { get; set;}
        
        [Required(ErrorMessage = "Ingrese Tipo de Vehiculo")]
        [StringLength(100)]
        public string Tipo { get; set;}
        
        [Required(ErrorMessage = "Requiere Matricula del Vehiculo")]
        [StringLength(50)]
        public string Matricula { get; set;}
        
        [Required(ErrorMessage = "Requiere Modelo del Vehiculo")]
        [StringLength(10)]
        public string Modelo { get; set;}

        [Required(ErrorMessage = "Requiere Marca del Vehiculo")]
        [StringLength(50)]
        public string Marca { get; set;}

        [Required(ErrorMessage = "Requiere fecha de ingreso del Vehiculo")]
        public DateTime FechaIngreso { get; set;}

        [Required(ErrorMessage = "Requiere una descricion de la falla del Vehiculo")]
        [StringLength(2000)]
        public string Tipo_de_falla { get; set;}
          
        [ForeignKey("Cliente")] 
        public int Id_cliente { get; set;}

        [ForeignKey("Tecnico")] 
        public int Id_tecnico { get; set;}

        [ForeignKey("Revision")]
        public int Id_revision{get;set;}

        public ICollection<Cliente> ClienteLista  {get;set;} 

        public ICollection<Tecnico> TecnicoLista  {get;set;}

        public ICollection<Revision> RevisionLista {get;set;}
       
    }
}