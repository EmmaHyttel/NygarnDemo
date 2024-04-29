using NygarnDemo.Models;

namespace NygarnDemo.MockData;

public class MockKnittingNeedle
{
    private static List<KnittingNeedle> _knittingNeedles = new List<KnittingNeedle>()
    {
        new KnittingNeedle("Birketræ", "Strikkepinde", 3.50, 149, "Rundepinde", "Flottefarve", Enums.Brand.PetitKnit, 2, false),
        new KnittingNeedle("Stål", "Strikkepinde", 3.50, 100, "Strømpepinde", "Strømpepinde perfekt til at strikke strømper med", Enums.Brand.PetitKnit, 2, false),
        new KnittingNeedle("Birketræ", "Strikkepinde", 6, 149, "Rundepinde", "Sort", Enums.Brand.Sandnes, 2, true)

    };

    public static List<KnittingNeedle> GetAllKnittingNeedles()
    {
        return _knittingNeedles;
    }

}
