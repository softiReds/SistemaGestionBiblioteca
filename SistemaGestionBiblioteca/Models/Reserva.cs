namespace SistemaGestionBiblioteca.Models
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int LibroId {  get; set; }
        public int UsuarioId {  get; set; }
        public DateTime FechaReserva {  get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int EstadoReservaId { get; set; }

        public virtual Libro Libro { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual EstadoReserva EstadoReserva { get; set; }
    }
}
