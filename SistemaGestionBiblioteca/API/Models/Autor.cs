namespace SistemaGestionBiblioteca.Models
{
    public class Autor
    {
        public Guid AutorId {  get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}
