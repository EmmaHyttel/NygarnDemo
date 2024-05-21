namespace NygarnDemo.Models;

public class ShoppingCart
{
    public int ShoppingCartId { get; set; }
    public int ShoppingCartLineId { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public List<ShoppingCartLine> ShoppingCartLines { get; set; }

    public ShoppingCart(User user)
    {
        User = user;
        ShoppingCartLines = new List<ShoppingCartLine>();
    }

    public ShoppingCart()
    {
    }
}
