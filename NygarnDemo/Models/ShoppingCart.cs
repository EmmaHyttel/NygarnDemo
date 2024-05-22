namespace NygarnDemo.Models;

public class ShoppingCart
{
    public int Id { get; set; }
    public List<ShoppingCartLine> ShoppingCartLines { get; set; } = new List<ShoppingCartLine>();

    public ShoppingCart()
    {
    }
}
