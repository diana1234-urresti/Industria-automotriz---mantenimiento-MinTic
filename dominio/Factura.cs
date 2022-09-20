using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dominio
{
    public class Factura
    {
        [Key]
        public int Id_factura {get;set;}

        [Required(ErrorMessage="Ingrese la Fecha de facturacion, campo obligatorio")]
        public DateTime FechaFacturacion {get;set;}

        [Required(ErrorMessage="Ingrese el costo de la Revision")]
        public double CostoRevision {get;set;}

        [Required(ErrorMessage="Ingrese el costo del Repuesto")]
        public double CostoRepuesto {get;set;}
    
        [Required(ErrorMessage="Ingrese el valor del IVA")]
        public double Iva {get;set;}
        
        [Required(ErrorMessage="Ingrese el valor TOTAL")]
        public double Total{get;set;}
        //gfggg
    }
}
