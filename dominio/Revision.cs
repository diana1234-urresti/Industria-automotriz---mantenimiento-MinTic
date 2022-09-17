using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dominio
{
    public class Revision
    {
        [Key]
        public int Id {get;set;}

        [Required(ErrorMessage = "Ingrese Número de Revisión")]
        public int NoRevision {get;set;}

        [Required(ErrorMessage = "Ingrese Placa del vehiculo")]
        [StringLength(50)]
        public string NoPlaca {get;set;}

        [Required(ErrorMessage = "Ingrese Tipo de mantenimiento")]
        [StringLength(50)]
        public string TipoMantenimiento {get;set;}
        
        [Required(ErrorMessage = "Fecha de Revision Obligatoria")]
        public DateTime FechaRevision {get;set;}

        [Required(ErrorMessage = "Ingrese el Estado del Filtro")]
        [StringLength(50)]
        public string EstadoFiltro {get;set;}

        [Required(ErrorMessage = "Ingrese el Repuesto")]
        [StringLength(50)]
        public string Repuesto {get;set;}

        [Required(ErrorMessage = "Ingrese el Estado del Aceite")]
        [StringLength(50)]
        public string EstadoAceite {get;set;}
    }
}
