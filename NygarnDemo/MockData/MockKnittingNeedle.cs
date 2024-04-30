using NygarnDemo.Enums;
using NygarnDemo.Models;

namespace NygarnDemo.MockData;

public class MockKnittingNeedle
{
    private static List<KnittingNeedle> _knittingNeedles = new List<KnittingNeedle>()
    {
        new KnittingNeedle(NeedleAndHookMaterial.plastik, Size.Size30mm, NeedleType.rundpinde, "Knit", "Gode til alt", Brand.Hobbii, 2, 149, true), 
        new KnittingNeedle(NeedleAndHookMaterial.aluminium, Size.Size40mm, NeedleType.jumperpinde, "Hot", "Dejlig store", Brand.PetitKnit, 2, 499, true),
        new KnittingNeedle(NeedleAndHookMaterial.aluminium, Size.Size40mm, NeedleType.strømpepinde, "Hot", "gode til strømper", Brand.PetitKnit, 2, 499, true)

    };

    public static List<KnittingNeedle> GetAllKnittingNeedles()
    {
        return _knittingNeedles;
    }

}
