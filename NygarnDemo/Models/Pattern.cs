using NygarnDemo.Enums;

namespace NygarnDemo.Models;
public class Pattern : Product
{
    public Pattern(string designer, DifficultyLevel difficultyLevel, Category category, Fits fits, decimal price, 
        string name, string description, string brand, int amount) : base(price, name, description, brand, amount)
    {
        Designer = designer;
        DifficultyLevel = difficultyLevel;
        Category = category;
        Fits = fits;
        FreePattern = false;
    }

    public string? Designer { get; set; }
    public DifficultyLevel DifficultyLevel { get; set; }
    public Category Category { get; set; }
    public Fits Fits { get; set; }
    public bool FreePattern { get; set; }

    public Pattern() : base()
    {
        Designer = "";
        DifficultyLevel = 0;
        Category = 0;
        Fits = 0;
        FreePattern = false;
    }
}
