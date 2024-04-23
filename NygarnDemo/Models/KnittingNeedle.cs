namespace NygarnDemo.Models
{
    public class KnittingNeedle : Product
    {
        public string Materiale { get; set; }
        public string Type { get; set; }
        public double Size { get; set; }


        public KnittingNeedle(double price, string name, string description, string brand, int amount, string materiale, string type, double size) : base(price, name, description, brand, amount)
        {
            Materiale = materiale;
            Type = type; 
            Size = size;
        }

        public KnittingNeedle() 
        { 
        }
    }

}
