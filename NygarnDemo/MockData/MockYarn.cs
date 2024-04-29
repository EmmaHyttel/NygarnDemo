using NygarnDemo.Models;
using NygarnDemo.Enums;

namespace NygarnDemo.MockData;

public class MockYarn
{
    private static List<Yarn> _yarnProducts = new List<Yarn>() 
    {
        new Yarn(Color.Beige, KnittigTension.knittingTension21mX10cm, Yardage.Yardage215mPr50g, Material.Mohair, 50, "Anbefalede pinde 2-3", "30 grader", 79, "MyHair", 
            "Vildt lækkert mohair garn til din næste sweater", Brand.Sandnes, 1),
        new Yarn(Color.Grøn, KnittigTension.knittingTension25mX10cm, Yardage.Yardage300mPr50g, Material.Alpakka, 50, "Anbefalede pinde 4-5", "40 grader", 69, "MaLamaa", 
            "Vildt lækkert alpakka garn til dit næste tørklæde", Brand.PetitKnit, 1),
        new Yarn(Color.Rød, KnittigTension.knittingTension30mX10cm, Yardage.Yardage400mPr50g, Material.Silke, 50, "Anbefalede pinde 1-2", "Håndvaskes kun", 75, "SlikkeSilke", 
            "Vildt lækkert silke garn til dit næste hårbånd", Brand.PetitKnit, 1),
    };

    public static List<Yarn> GetAllYarnProducts()
    {
        return _yarnProducts;
    }
}
