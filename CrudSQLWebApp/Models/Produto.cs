using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CrudSQLWebApp.Models
{
    [Table("Produto")]//annotation definir o nome da Rabela no banco diferente da classe
    public class Produto
    {
        [Column("Id")]//annotation definir o nome da Coluna no banco diferente da classe
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Preco")]
        [Display(Name = "Preco")]
        public int Preco { get; set; }

        [Column("Qtd")]
        [Display(Name = "Qtd")]
        public int Quantidade { get; set; }
    }
}
