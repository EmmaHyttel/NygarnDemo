namespace NygarnDemo.Models;

public class Yarn : Product
{

    public string Color { get; set; }
    public string KnittingTension { get; set; }
    public string Yardage { get; set; }
    public string Material { get; set; }
    public int Weight { get; set; }

    public Yarn(string color, string knittingTension, string yardage, string material, int weight, double price, string name, string description, string brand, int amount) : base(price, name, description, brand, amount)
    {
        Color = color;
        KnittingTension = knittingTension;
        Yardage = yardage;
        Material = material;
        Weight = weight; 
    }

    public Yarn()
    {
    }

}
