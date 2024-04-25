namespace NygarnDemo.Models;

public class CrochetHook : Product
{
   
    public string Materiale { get; set; }
    public double Size { get; set; }


    public CrochetHook(string materiale, double size, decimal price, string name, string description, string brand, int amount) : base(price, name, description, brand, amount)
    {
        Materiale = materiale; 
        Size = size;
    }

    public CrochetHook(decimal price, string name, string description, string brand, int amount) : base(price, name, description, brand, amount)
    {
        Materiale = "default";
        Size = 0;
    }
}
