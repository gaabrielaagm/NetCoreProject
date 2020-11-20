using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; } //System.DateTime
        public byte[] FotoPortada { get; set; }

        // relaciones|anclas
        public Precio PrecioPromocion { get; set; }
        public ICollection<Comentario> ComentarioLista { get; set; }  
        public ICollection<CursoInstructor> InstructoresLink { get; set; }
    }
}