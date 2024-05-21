using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NygarnDemo.Models
{
    public class WishList
    {
        [Key]
        public int WishListId { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
       
        public int UserId { get; set; }

        public CrochetHook CrochetHook { get; set; }

        public KnittingNeedle KnittingNeedle { get; set; }

        public Pattern Pattern { get; set; }

        public Yarn Yarn { get; set; }

        public Tool Tool { get; set; }

        [ForeignKey("Id")]
        public User User { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public WishList(int wishListId, int productId, int userId, CrochetHook crochetHook, 
            KnittingNeedle knittingNeedle, Pattern pattern, Yarn yarn, Tool tool, User user, 
            List<Product> products)
        {
            WishListId = wishListId;
            ProductId = productId;
            UserId = userId;
            CrochetHook = crochetHook;
            KnittingNeedle = knittingNeedle;
            Pattern = pattern;
            Yarn = yarn;
            Tool = tool;
            User = user;
            Products = products;
        }

        public WishList()
        {

        }
    }
}
