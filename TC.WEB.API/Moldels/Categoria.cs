using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TC.WEB.API.Moldels
{
    public class Categoria
    {
        public Categoria()
        {
            this.Produtos = new HashSet<Produto>();
        }

        [Key]
        public int Id { get; set; }

        //[Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }

    }
}
