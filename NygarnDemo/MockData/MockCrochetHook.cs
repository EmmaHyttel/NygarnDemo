using NygarnDemo.Enums;
using NygarnDemo.Models;

namespace NygarnDemo.MockData;

public class MockCrochetHook
{
    private static List<CrochetHook> _crochetHooks = new List<CrochetHook>()
    {
       new CrochetHook(NeedleAndHookMaterial.aluminium, Size.Size25mm, "lort", "træt af det pis", Brand.PetitKnit, 1, 69, false),
       new CrochetHook(NeedleAndHookMaterial.aluminium, Size.Size25mm, "lort", "træt af det pis", Brand.PetitKnit, 1, 69, false),
       new CrochetHook(NeedleAndHookMaterial.aluminium, Size.Size25mm, "lort", "træt af det pis", Brand.PetitKnit, 1, 69, false)
    };
    public static List<CrochetHook> GetAllCrochetHooks()
    {
        return _crochetHooks;
    }
}
