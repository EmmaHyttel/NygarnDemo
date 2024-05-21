using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NygarnDemo.Models
{
    public class WishList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WishListId { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }

        [ForeignKey("Id")]
        public int Id { get; set; } 

        public User User { get; set; }
        public Product Product { get; set; } 

        public WishList(User user, Product product)
        {
            User = user;
            Product = product;
        }

        public WishList()
        {

        }
    }
}
