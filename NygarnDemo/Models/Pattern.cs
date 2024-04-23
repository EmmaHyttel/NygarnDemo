namespace NygarnDemo.Models
{
    public class Pattern : Product
    {

        public string Designer { get; set; }
        public string DifficultyLevel { get; set; }

        public Pattern(string designer, string difficultyLevel, double price, string name, string description, string brand, int amount) : base(price, name, description, brand, amount)
        {
            Designer = designer;
            DifficultyLevel = difficultyLevel;
        }

        public Pattern(double price, string name, string description, string brand, int amount) : base(price, name, description, brand, amount)
        {
            Designer = "default";
            DifficultyLevel = "default";
        }

        public override string ToString()
        {
            return $"{{{nameof(Designer)}={Designer}, {nameof(DifficultyLevel)}={DifficultyLevel}, {nameof(ProductId)}={ProductId}, {nameof(Price)}={Price}, {nameof(Name)}={Name}, {nameof(Description)}={Description}, {nameof(Brand)}={Brand}, {nameof(Amount)}={Amount}}}";
        }
    }
}
