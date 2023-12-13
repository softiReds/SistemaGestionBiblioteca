namespace SistemaGestionBiblioteca.Models
{
    public class Libro
    {
        public Guid LibroId { get; set; }
        public string Titulo {  get; set; }
        public Guid AutorId {  get; set; }
        public int CantidadDisponible { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public virtual Autor Autor { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
