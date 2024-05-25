using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NygarnDemo.Models
{
    public class WishListLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Product Product { get; set; }

        public WishListLine(Product product)
        {
            Product = product;
        }

        public WishListLine()
        {
        }


    }
}
