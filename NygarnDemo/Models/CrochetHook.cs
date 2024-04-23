namespace NygarnDemo.Models
{
    public class CrochetHook : Product
    {
       
        public string Materiale { get; set; }
        public double Size { get; set; }


        public CrochetHook(double price, string name, string description, string brand, int amount, string materiale, double size) : base(price, name, description, brand, amount)
        {
            Materiale = materiale; 
            Size = size;
        }

        public CrochetHook()
        {
        }
    }
}
