using NygarnDemo.Enums;
using NygarnDemo.Models;


namespace NygarnDemo.MockData;

public class MockPattern
{
    private static List<Pattern> _patterns = new List<Pattern>()
    {
        new Pattern("Mette Wendelboe Okkels", DifficultyLevel.DiffLevelFive, Category.Cardigan, Fits.Kvinde, 50, "ESTHER JACKET", 
            "Esther Jacket strikkes oppefra og ned med strukturstrik.", Brand.PetitKnit, 1),
        new Pattern("Mette Wendelboe Okkels", DifficultyLevel.DiffLevelThree, Category.Sweater, Fits.Barn, 45, "CLOUD SWEATER JUNIOR", 
            "Cloud Sweater Junior strikkes oppefra og ned.", Brand.PetitKnit, 1),
        new Pattern("Knitting for Olive", DifficultyLevel.DiffLevelSix, Category.Hue, Fits.Baby, 50, "LILLERILLEBJØRNHUE", 
            "Lillerillebjørnhuen er en begyndervenlig lille hue i kysefacon med små bjørneører.", Brand.Sandnes, 1)
    };

    public static List<Pattern> GetAllPatterns()
    {
        return _patterns;
    }
}
