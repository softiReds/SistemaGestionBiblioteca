namespace SistemaGestionBibliotecaAPI.Models
{
    public class EstadoReserva
    {
        public Guid EstadoReservaId {  get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
