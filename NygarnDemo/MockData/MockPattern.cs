using System.Runtime.InteropServices;

namespace NygarnDemo.MockData
{
    public class MockPattern
    {
        private static List<Models.Pattern> _patterns = new List<Models.Pattern>()
        {
            new Models.Pattern("Mette Wendelboe Okkels", "5 ud af 5", 50.00, "ESTHER JACKET", "Esther Jacket strikkes oppefra og ned med strukturstrik.", "PetiteKnit", 1),
            new Models.Pattern("Mette Wendelboe Okkels", "3 ud af 5", 45.00, "CLOUD SWEATER JUNIOR", "Cloud Sweater Junior strikkes oppefra og ned.", "PetiteKnit", 1),
            new Models.Pattern("Knitting for Olive", "Begynder", 50.00, "LILLERILLEBJØRNHUE", "Lillerillebjørnhuen er en begyndervenlig lille hue i kysefacon med små bjørneører.", "Knitting for Olive", 1)
        };

        public static List<Models.Pattern> GetAllPatterns()
        {
            return _patterns;
        }
    }
}
