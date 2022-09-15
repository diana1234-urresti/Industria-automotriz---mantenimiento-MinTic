using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace dominio
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set;}
        [Required(ErrorMessage = "Ingrese el titulo")]
        [StringLength(100)]
        public string Titulo { get; set;}
        [Required(ErrorMessage = "Ingrese una descripcion")]
        [StringLength(2000)]
        public string Descripcion { get; set;}
        [Required(ErrorMessage = "Fecha Publicacion de Ingreso Obligatorio")]
        [StringLength(50)]
        public DateTime FechaPublicacion {get;set;}
        
        public byte [] fotoPortada {get;set;}

        public Precio Precio {get;set;}     

        //public ICollection<Comentario> ComentarioLista {get;set;}  

    }
}