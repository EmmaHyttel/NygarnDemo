using NygarnDemo.Models;

namespace NygarnDemo.MockData;

public class MockKnittingNeedle
{
    private static List<KnittingNeedle> _knittingNeedles = new List<KnittingNeedle>()
    {
        new KnittingNeedle("Birketræ", "Strikkepinde", 3.50, 149, "Rundepinde", "Flottefarve", "KnitPro", 2),
        new KnittingNeedle("Birketræ", "Strikkepinde", 3.50, 149, "Rundepinde", "Flottefarve", "KnitPro", 2),
        new KnittingNeedle("Birketræ", "Strikkepinde", 3.50, 149, "Rundepinde", "Flottefarve", "KnitPro", 2)

    };

    public static List<KnittingNeedle> GetAllKnittingNeedles()
    {
        return _knittingNeedles;
    }

}
