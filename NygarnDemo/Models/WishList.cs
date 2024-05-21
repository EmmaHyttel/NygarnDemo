//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace NygarnDemo.Models
//{
//    public class WishList
//    {
//        [Key]
//        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//        public int WishListId { get; set; }

//        [ForeignKey("ProductId")]
//        public int ProductId { get; set; }

//        [ForeignKey("Id")]
//        public int Id { get; set; } 

//        public User User { get; set; }
//        public List<Product> WishListProducts { get; set; } 

//        public WishList(User user)
//        {
//            User = user;
//            WishListProducts = new List<Product>();
//        }

//        public WishList()
//        {

//        }

         
//    }
//}
