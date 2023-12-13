using Microsoft.EntityFrameworkCore;
using SistemaGestionBiblioteca.Models;

namespace SistemaGestionBiblioteca.Context
{
    public class GestionBibliotecaContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<EstadoReserva> EstadosReserva { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Reserva> Reservas {  get; set; }
        public DbSet<TipoUsuario> TiposUsuario {  get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public GestionBibliotecaContext(DbContextOptions<GestionBibliotecaContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Autor>(autor =>
            {
                autor.ToTable("Autor");
                autor.HasKey(p => p.AutorId);

                autor.Property(p => p.Nombre).IsRequired().HasMaxLength(60);
            });

            builder.Entity<EstadoReserva>(estadoReserva =>
            {
                estadoReserva.ToTable("EstadoReserva");
                estadoReserva.HasKey(p => p.EstadoReservaId);

                estadoReserva.Property(p => p.Descripcion).IsRequired().HasMaxLength(60);
            });

            builder.Entity<Libro>(libro =>
            {
                libro.ToTable("Libro");
                libro.HasKey(p => p.LibroId);

                libro.HasOne(p => p.Autor).WithMany(p => p.Libros).HasForeignKey(p => p.AutorId);

                libro.Property(p => p.Titulo).IsRequired();
                libro.Property(p => p.CantidadDisponible).IsRequired();
                libro.Property(p => p.FechaPublicacion);
            });

            builder.Entity<Reserva>(reserva =>
            {
                reserva.ToTable("Reserva");
                reserva.HasKey(p => p.ReservaId);

                reserva.HasOne(p => p.Libro).WithMany(p => p.Reservas).HasForeignKey(p => p.LibroId);
                reserva.HasOne(p => p.Usuario).WithMany(p => p.Reservas).HasForeignKey(p => p.UsuarioId);
                reserva.HasOne(p => p.EstadoReserva).WithOne(p => p.Reserva).HasForeignKey<Reserva>(p => p.EstadoReservaId);

                reserva.Property(p => p.FechaReserva).IsRequired();
                reserva.Property(p => p.FechaDevolucion);
            });

            builder.Entity<TipoUsuario>(tipoUsuario =>
            {
                tipoUsuario.ToTable("TipoUsuario");
                tipoUsuario.HasKey(p => p.TipoUsuarioId);

                tipoUsuario.Property(p => p.Descripcion).IsRequired().HasMaxLength(30);
            });

            builder.Entity<Usuario>(usuario =>
            {
                usuario.ToTable("Usuario");
                usuario.HasKey(p => p.UsuarioId);

                usuario.HasOne(p => p.TipoUsuario).WithOne(p => p.Usuario).HasForeignKey<Usuario>(p => p.TipoUsuarioId);

                usuario.Property(p => p.Nombre).IsRequired();
                usuario.Property(p => p.Apellido).IsRequired();
                usuario.Property(p => p.CorreoElectronico).IsRequired();
                usuario.Property(p => p.Contraseña).IsRequired();
            });
        }
    }
}
