using TC.WEB.API.Moldels;

namespace TC.WEB.API.Repositories
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> Get();

        Task<Categoria> Get(int id);

        Task<Categoria> Create(Categoria categoria);

        Task Update(Categoria categoria);

        Task Delete(int id);
    }
}
