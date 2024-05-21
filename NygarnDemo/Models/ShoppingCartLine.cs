using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NygarnDemo.Models
{
    public class ShoppingCartLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("ProductId")]
        [Required]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int Count { get; set; }

        public ShoppingCartLine(Product product, int count)
        {
            Product = product;
            Count = count;
        }

        public ShoppingCartLine()
        {
        }
    }
}
