namespace NygarnDemo.MockData
{
    public class MockTool
    {
        private static List<Models.Tool> tools = new List<Models.Tool>() 
        {
          new Models.Tool("Blå", "Knapper", "1x1 cm", 35, "KnappeLappe", "Fine små knapper der holder jakken lukket", "Sandes", 20),
          new Models.Tool("Hvid", "Lynlås", "17x3 cm", 15, "LynhurtigLynild", "Super holdbar lynlås, der lynes op med lynets hastighed", "Stof&Stil", 1),
          new Models.Tool("Pink", "Saks", "Voksen", 40, "SakseLakse", "Super god højrehåndssaks i voksenstørrelse, der gør dine projekter meget nemmere at klippe igennem", "Panduro", 2)
        };

        public static List<Models.Tool> GetMockTool()
        {
            return tools;
        }
    }
}
