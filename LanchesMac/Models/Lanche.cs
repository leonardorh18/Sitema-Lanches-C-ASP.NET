using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {

        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "informe o nome do lanche")]
        [Display( Name = "Nome do lanche")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = " o {0} deve ter no minimo {1} e no maximo {2}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "informe uma descricao curta")]
        [Display(Name = "Descricao curta")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = " o {0} deve ter no minimo {1} e no maximo {2}")]
        public string DescricaoCurta { get; set; }


        [Required(ErrorMessage = "informe uma descricao curta")]
        [Display(Name = "Descricao curta")]
        [MaxLength(500, ErrorMessage = "Deve ter no maximo 500 caracteres")]
        [MinLength(50, ErrorMessage = "Deve ter no minimo 50 caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "informe o preço")]
        [Display(Name = "Preço do lanche")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99,  ErrorMessage = "Preço entre 1 e 999.99")]
        public decimal Preco { get; set; }

        [Display(Name = "Imagem do lanche")]
        [StringLength(500, ErrorMessage = "Deve ter no maximo 500 caracteres")]
        public string ImagemUrl { get; set; }


        [Display(Name = "Imagem da thumb")]
        [StringLength(500, ErrorMessage = "Deve ter no maximo 500 caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Em estoque?")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }


    }
}
