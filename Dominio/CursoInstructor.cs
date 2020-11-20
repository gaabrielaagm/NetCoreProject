namespace Dominio
{
    public class CursoInstructor
    {
        public int CursoId { get; set; }
        public int InstructorId { get; set; }

        // relaciones
        public Curso Curso { get; set; }
        public Instructor Instructor { get; set; }
    }
}