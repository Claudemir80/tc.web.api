using Castle.MicroKernel.SubSystems.Conversion;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TC.WEB.API.Moldels
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        //[Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public decimal? Estoque { get; set; }

        public string DataCadastro { get; set; }

        public virtual ICollection<Categoria> Categorias { get; set; }
    }
}
