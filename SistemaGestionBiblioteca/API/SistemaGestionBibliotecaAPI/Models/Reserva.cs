namespace SistemaGestionBibliotecaAPI.Models
{
    public class Reserva
    {
        public Guid ReservaId { get; set; }
        public Guid LibroId { get; set; }
        public Guid UsuarioId {  get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public Guid EstadoReservaId { get; set; }

        public virtual Libro Libro { get; set; }
        public virtual Usuario Usuario {  get; set; }
        public virtual EstadoReserva EstadoReserva { get; set; }
    }
}
