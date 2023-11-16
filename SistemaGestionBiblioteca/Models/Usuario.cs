namespace SistemaGestionBiblioteca.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña {  get; set; }
        public int TipoUsuarioId { get; set; }

        public virtual TipoUsuario TipoUsuario { get; set; }
    }
}
