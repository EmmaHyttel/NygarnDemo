namespace NygarnDemo.MockData;
using NygarnDemo.Enums;
using NygarnDemo.Models;
using System;

public class MockTool
{
    private static List<Tool> _tools = new List<Tool>() 
    {
      new Tool("Gul", ToolType.Knapper, "1x1 cm", 35, "KnappeLappe", "Fine små knapper der holder jakken lukket", Brand.PetitKnit, 20),
      new Tool("Brun", ToolType.Lynlås, "17x3 cm", 15, "LynhurtigLynild", "Super holdbar lynlås, der lynes op med lynets hastighed", Brand.Sandnes, 1),
      new Tool("Lilla", ToolType.Saks, "Voksen", 40, "SakseLakse", "Super god højrehåndssaks i voksenstørrelse, " +
          "der gør dine projekter meget nemmere at klippe igennem", Brand.Hobbii, 2)
    };
    internal static List<Tool> GetAllToolProducts()
    {
        return _tools; 
    }
}
