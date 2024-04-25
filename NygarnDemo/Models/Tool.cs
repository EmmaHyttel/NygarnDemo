namespace NygarnDemo.Models;

public class Tool : Product
{

    public string Color { get; set; }
    public string Type { get; set; }
    public string Size { get; set; }

    public Tool(string color, string type, string size, double price, string name, string description, string brand, int amount) : base(price, name, description, brand, amount)
    {
        Color = color;
        Type = type;
        Size = size;
    }

}


