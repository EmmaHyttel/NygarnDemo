using NygarnDemo.Models;

namespace NygarnDemo.MockData;

public class MockCrochetHook
{
    private static List<CrochetHook> _crochetHooks = new List<CrochetHook>()
    {
        new CrochetHook("Stål", 2.0, 49, "Waves", "Soft grib", "KnitPro", 1, false),
        new CrochetHook("Aluminium", 2.0, 400, "Waves", "Soft grib", "KnitPro", 1, false),
        new CrochetHook("Træ", 2.0, 499, "Hot", "Soft grib", "KnitPro", 6, true)
    };

    public static List<CrochetHook> GetAllCrochetHooks()
    {
        return _crochetHooks;
    }

}
