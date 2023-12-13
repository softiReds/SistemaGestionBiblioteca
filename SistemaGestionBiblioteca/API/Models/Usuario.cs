namespace SistemaGestionBiblioteca.Models
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña {  get; set; }
        public Guid TipoUsuarioId { get; set; }

        public virtual TipoUsuario TipoUsuario { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
