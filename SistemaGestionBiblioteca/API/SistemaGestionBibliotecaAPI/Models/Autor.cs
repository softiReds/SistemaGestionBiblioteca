namespace SistemaGestionBibliotecaAPI.Models
{
    public class Autor
    {
        public Guid AutorId {  get; set; }
        public string AutorNombre { get; set; }
    
        public virtual ICollection<Libro> Libros { get; set; }
    }
}
