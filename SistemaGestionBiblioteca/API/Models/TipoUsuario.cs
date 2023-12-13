namespace SistemaGestionBiblioteca.Models
{
    public class TipoUsuario
    {
        public int TipoUsuarioId { get; set; }
        public string Descripcion { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
