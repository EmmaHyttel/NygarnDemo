using NygarnDemo.Models;

namespace NygarnDemo.MockData;

public class MockYarn
{
    private static List<Yarn> _yarnProducts = new List<Yarn>() 
    {
        new Yarn("Rød", "27-31 masker = 10 cm", "ca 175 m. pr 50 g.", "Mohair", 50, "Anbefalede pinde 2-3", "30 grader", 79, "MyHair", 
            "Vildt lækkert mohair garn til din næste sweater", "Sandes", 1),
        new Yarn("Beige", "23-26 masker = 10 cm", "ca 195 m. pr 50 g.", "Alpakka", 50, "Anbefalede pinde 4-5", "40 grader", 69, "MaLamaa", 
            "Vildt lækkert alpakka garn til dit næste tørklæde", "PetitKnit", 1),
        new Yarn("Gul", "28-32 masker = 10 cm", "ca 215 m. pr 50 g.", "Silke", 50, "Anbefalede pinde 1-2", "Håndvaskes kun", 75, "SlikkeSilke", 
            "Vildt lækkert silke garn til dit næste hårbånd", "PetitKnit", 1),    
    };

    public static List<Yarn> GetAllYarnProducts()
    {
        return _yarnProducts;
    }
}
