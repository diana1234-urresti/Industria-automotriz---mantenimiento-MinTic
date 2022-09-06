using System;

namespace dominio
{
    public class Factura
    {
        public int Id {get;set;}
        public string FechaFacturacion {get;set;}
        public double CostoRevision {get;set;}
        public double CostoRepuesto {get;set;}
        public double Iva {get;set;}
        public double Total{get;set;}
        
    }
}
