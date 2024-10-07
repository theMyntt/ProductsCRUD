using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsCRUD.WebUI.Models
{
    [Table("TBL_PRODUTOS")]
    public class ProductEntity
    {
        [Key]
        [Required]
        [Column("ID_PRODUTO")]
        public Guid Id { get; set; }

        [Required]
        [Column("TX_NOME")]
        public string? Name { get; set; }

        [Required]
        [Column("TX_PRECO")]
        public double Price { get; set; }

        [Required]
        [Column("TX_TIMESTAMP")]
        public long Timestamp { get; set; }
    }
}
