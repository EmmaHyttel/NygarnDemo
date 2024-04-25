using NygarnDemo.Models;


namespace NygarnDemo.MockData;

public class MockPattern
{
    private static List<Pattern> _patterns = new List<Pattern>()
    {
        new Pattern("Mette Wendelboe Okkels", "5 ud af 5", Enums.Category.Cardigan, Enums.Fits.Kvinde, false, 50, "ESTHER JACKET", 
            "Esther Jacket strikkes oppefra og ned med strukturstrik.", "PetiteKnit", 1),
        new Pattern("Mette Wendelboe Okkels", "3 ud af 5", Enums.Category.Sweater, Enums.Fits.Barn, false, 45, "CLOUD SWEATER JUNIOR", 
            "Cloud Sweater Junior strikkes oppefra og ned.", "PetiteKnit", 1),
        new Pattern("Knitting for Olive", "Begynder", Enums.Category.Hue, Enums.Fits.Baby, false, 50, "LILLERILLEBJØRNHUE", 
            "Lillerillebjørnhuen er en begyndervenlig lille hue i kysefacon med små bjørneører.", "Knitting for Olive", 1)
    };

    public static List<Pattern> GetAllPatterns()
    {
        return _patterns;
    }
}
