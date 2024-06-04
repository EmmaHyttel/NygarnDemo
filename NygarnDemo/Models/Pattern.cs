using NygarnDemo.Enums;

namespace NygarnDemo.Models;
public class Pattern : Product
{
    public Pattern(string designer, string difficultyLevel, Category category, Fits fits, decimal price, 
        string name, string description, string brand) : base(price, name, description, brand)
    {
        Designer = designer;
        DifficultyLevel = difficultyLevel;
        Category = category;
        Fits = fits;
        FreePattern = false;
    }

    public string? Designer { get; set; }
    public string DifficultyLevel { get; set; }
    public Category Category { get; set; }
    public Fits Fits { get; set; }
    public bool FreePattern { get; set; }

    public Pattern() : base()
    {
        Designer = "";
        DifficultyLevel = "";
        Category = 0;
        Fits = 0;
        FreePattern = false;
    }
}
