namespace NygarnDemo.Models;

public class Product
{
    private static int _nextId = 0;
    public int ProductId { get; set; }
    public double Price { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Brand { get; set; }
    public int Amount { get; set; }

    public Product(double price, string name, string description, string brand, int amount)
    {
        ProductId = _nextId++;
        Price = price;
        Name = name;
        Description = description;
        Brand = brand;
        Amount = amount;
    }

    public Product()
    {
        ProductId = 1234;
        Price = 0;
        Name = "testProdukt";
        Description = "Beskrivelse";
        Brand = "Brand";
        Amount = 0;
    }

}
