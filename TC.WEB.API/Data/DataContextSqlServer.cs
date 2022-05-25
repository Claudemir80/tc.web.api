using Microsoft.EntityFrameworkCore;
using TC.WEB.API.Moldels;

namespace TC.WEB.API.Data
{
    public class DataContextSqlServer : DbContext
    {
        public DataContextSqlServer(DbContextOptions<DataContextSqlServer> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
