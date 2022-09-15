using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dominio
{
    public class Precio
    {
        [Key]
        public int PrecioId { get; set;}
        [Required(ErrorMessage = "Ingrese el precio")]
        [StringLength(100)]
        public decimal PrecioActual  { get; set;}
        [Required(ErrorMessage = "Ingrese Promocion")]
        public decimal Promocion  { get; set;}
        [ForeignKey("Curso")] 
        public int CursoId  { get; set;}

        public virtual Curso curso { get; set;}
        

    }
}