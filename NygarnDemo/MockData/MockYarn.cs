using NygarnDemo.Models;

namespace NygarnDemo.MockData
{
    public class MockYarn
    {
        private static List<Yarn> yarns = new List<Yarn>() 
        {
            new Yarn("Rød", "27-31 masker = 10 cm", "ca 175 m. pr 50 g.", "Mohair", 50, 79, "MyHair", "Vildt lækkert mohair garn til din næste sweater", "Sandes", 1),
            new Yarn("Beige", "23-26 masker = 10 cm", "ca 195 m. pr 50 g.", "Alpakka", 50, 69, "MaLamaa", "Vildt lækkert alpakka garn til dit næste tørklæde", "PetitKnit", 1),
            new Yarn("Gul", "28-32 masker = 10 cm", "ca 215 m. pr 50 g.", "Silke", 50, 75, "SlikkeSilke", "Vildt lækkert silke garn til dit næste hårbånd", "PetitKnit", 1),    
        };

        public static List<Yarn> GetMockYarn()
        {
            return yarns;
        }
    }
}
