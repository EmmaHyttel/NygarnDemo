namespace NygarnDemo.Models
{
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

        public override string ToString()
        {
            return $"{{{nameof(Color)}={Color}, {nameof(Type)}={Type}, {nameof(Size)}={Size}, {nameof(ProductId)}={ProductId.ToString()}, {nameof(Price)}={Price.ToString()}, {nameof(Name)}={Name}, {nameof(Description)}={Description}, {nameof(Brand)}={Brand}, {nameof(Amount)}={Amount.ToString()}}}";
        }
    }

    
}
