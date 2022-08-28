using System;

namespace dominio
{
    public class Revision
    {
        public int Id {get;set;}
        public int NoRevision {get;set;}
        public string NoPlaca {get;set;}
        public string TipoMantenimiento {get;set;}
        
        public string FechaRevision {get;set;}
        public string EstadoFiltro {get;set;}
        public string Repuesto {get;set;}
        public string EstadoAceite {get;set;}
    }
}
