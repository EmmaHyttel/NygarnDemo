using NygarnDemo.Enums;
using NygarnDemo.Models;

namespace NygarnDemo.MockData;

public class MockCrochetHook
{
    private static List<CrochetHook> _crochetHooks = new List<CrochetHook>()
    {
        new CrochetHook(NeedleAndHookMateriale.aluminium, Size.Size35mm, "Waves", "Soft grib", Brand.Sandnes, 1, 49, false),
        new CrochetHook(NeedleAndHookMateriale.bambus, Size.Size20mm, "Hot", "Soft grib", Brand.Hobbii, 1, 199, false),
        new CrochetHook (NeedleAndHookMateriale.metal, Size.Size30mm, "Waves", "Hard grib", Brand.PetitKnit, 1, 99, false)
    };
    public static List<CrochetHook> GetAllCrochetHooks()
    {
        return _crochetHooks;
    }

}
