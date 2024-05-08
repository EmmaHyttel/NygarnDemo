using NygarnDemo.Enums;
using NygarnDemo.Models;

namespace NygarnDemo.MockData;

public class MockKnittingNeedle
{
    private static List<KnittingNeedle> _knittingNeedles = new List<KnittingNeedle>()
    {
        new KnittingNeedle(NeedleAndHookMaterial.plastik, Size.Size30mm, NeedleType.Rundpinde, "Knitpro", "Gode til alt", "Petitknit", 2, 149, true), 
        new KnittingNeedle(NeedleAndHookMaterial.bambus, Size.Size40mm, NeedleType.Jumperpinde, "Hot", "Dejlig store", "Petitknit", 2, 499, true),
        new KnittingNeedle(NeedleAndHookMaterial.aluminium, Size.Size40mm, NeedleType.Strømpepinde, "Hot", "gode til strømper", "Petitknit", 2, 499, true)

    };

    public static List<KnittingNeedle> GetAllKnittingNeedles()
    {
        return _knittingNeedles;
    }

}
