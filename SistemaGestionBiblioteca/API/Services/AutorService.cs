using SistemaGestionBiblioteca.Context;
using SistemaGestionBiblioteca.Models;

namespace SistemaGestionBibliotecaAPI.Services
{
    public class AutorService : IAutorService
    {
        GestionBibliotecaContext context;

        public AutorService(GestionBibliotecaContext context)
        {
            this.context = context;
        }

        public IEnumerable<Autor> Get()
        {
            return context.Autores;
        }

        public async Task Save(Autor autor)
        {
            await context.Autores.AddAsync(autor);

            await context.SaveChangesAsync();
        }

        public async Task Update(Autor autor, Guid id)
        {
            Autor autorActualizar = context.Autores.Find(id);

            if(autorActualizar != null)
            {
                autorActualizar.Nombre = autor.Nombre;

                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(Guid id)
        {
            Autor autorEliminar = context.Autores.Find(id);

            if(autorEliminar != null)
            {
                context.Autores.Remove(autorEliminar);

                await context.SaveChangesAsync();
            }
        }
    }

    public interface IAutorService
    {
        IEnumerable<Autor> Get();
        Task Save(Autor autor);
        Task Update(Autor autor, Guid id);
        Task Delete(Guid id);
    }
}
