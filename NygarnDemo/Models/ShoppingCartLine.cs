using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NygarnDemo.Models
{
    public class ShoppingCartLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public ShoppingCartLine(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public ShoppingCartLine()
        {
        }

        public decimal CalculateLineTotal()
        {
			return Product.Price * Quantity;
		}
    }
}
