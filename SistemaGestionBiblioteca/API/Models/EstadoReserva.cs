namespace SistemaGestionBiblioteca.Models
{
    public class EstadoReserva
    {
        public Guid EstadoReservaId { get; set; }
        public string Descripcion { get; set; }

        public virtual Reserva Reserva { get; set; }
    }
}
