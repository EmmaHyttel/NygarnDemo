using NygarnDemo.Models;
using NygarnDemo.Enums;

namespace NygarnDemo.MockData;

public class MockYarn
{
    private static List<Yarn> _yarnProducts = new List<Yarn>() 
    {
        new Yarn(Color.Beige, "knittingTension21mX10cm", Yardage.Yardage215mPr50g, Material.Mohair, 50, Size.Size20mm, true, 79, "MyHair", 
            "Vildt lækkert mohair garn til din næste sweater", "Petitknit", 1),
        new Yarn(Color.Grøn, "knittingTension: 25mX10cm", Yardage.Yardage300mPr50g, Material.Alpakka, 50, Size.Size30mm, true, 69, "MaLamaa", 
            "Vildt lækkert alpakka garn til dit næste tørklæde", "Petitknit", 1),
        new Yarn(Color.Rød, "knittingTension: 30mX10cm", Yardage.Yardage400mPr50g, Material.Silke, 50, Size.Size40mm, false, 75, "SlikkeSilke", 
            "Vildt lækkert silke garn til dit næste hårbånd", "Petitknit", 1)
    };

    public static List<Yarn> GetAllYarnProducts()
    {
        return _yarnProducts;
    }
}
