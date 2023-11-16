namespace SistemaGestionBiblioteca.Models
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Titulo {  get; set; }
        public int AutorId {  get; set; }
        public int CantidadDisponivle { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public virtual Autor Autor { get; set; }
    }
}
