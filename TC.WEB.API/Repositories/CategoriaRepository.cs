using Microsoft.EntityFrameworkCore;
using TC.WEB.API.Data;
using TC.WEB.API.Moldels;

namespace TC.WEB.API.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public readonly DataContextSqlServer _context;

        public CategoriaRepository(DataContextSqlServer context)
        {
            _context = context;
        }

        public async Task<Categoria> Create(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }

        public async Task Delete(int id)
        {
            var categoiadelete = await _context.Categorias.FindAsync(id);
            _context.Remove(categoiadelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Categoria>> Get()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<Categoria> Get(int id)
        {
            return await _context.Categorias.FindAsync(id);
        }

        public async Task Update(Categoria categoria)
        {
            _context.Entry(categoria).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
