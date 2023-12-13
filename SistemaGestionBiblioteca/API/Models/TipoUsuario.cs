namespace SistemaGestionBiblioteca.Models
{
    public class TipoUsuario
    {
        public Guid TipoUsuarioId { get; set; }
        public string Descripcion { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
