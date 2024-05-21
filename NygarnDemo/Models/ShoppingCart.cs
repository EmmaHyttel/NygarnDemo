namespace NygarnDemo.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public int SCLineId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<SCLine> SCLines { get; set; }

        public ShoppingCart(User user)
        {
            User = user;
            SCLines = new List<SCLine>();
        }

        public ShoppingCart()
        {
        }
    }
}
