namespace SistemaGestionBiblioteca.Models
{
    public class Reserva
    {
        public int ReservaId { get; set; }
        public int LibroId {  get; set; }
        public int UsuarioId {  get; set; }
        public DateTime FechaReserva {  get; set; }
        public DateTime FechaDevolucion { get; set; }
        public EstadoReserva Estado { get; set; }
    }

    public enum EstadoReserva
    {
        Pendiente,
        Activada,
        Vencida,
        Devuelta
    }
}
