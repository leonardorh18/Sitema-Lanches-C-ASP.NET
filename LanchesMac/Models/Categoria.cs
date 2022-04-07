using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
       [Table("Categorias")]
    public class Categoria
    {
         [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Nome")]
        [StringLength(100, ErrorMessage = "Tamanho maximo: 100 caracteres")]
        public string CategoriaNome { get; set; }


        [Required(ErrorMessage = "Informe a descricao")]
        [Display(Name = "Descricao")]
        [StringLength(200, ErrorMessage = "Tamanho maximo: 200 caracteres")]

        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }

    }
}
