namespace NygarnDemo.Models;

public class KnittingNeedle : Product
{
    public string Materiale { get; set; }
    public string Type { get; set; }
    public double Size { get; set; }


    public KnittingNeedle(string materiale, string type, double size, double price, string name, string description, string brand, int amount) : base(price, name, description, brand, amount)
    {
        Materiale = materiale;
        Type = type; 
        Size = size;
    }

    public KnittingNeedle() 
    { 
    }
}
