namespace NygarnDemo.MockData;
using NygarnDemo.Enums;
using NygarnDemo.Models;
using System;

public class MockTool
{
    private static List<Tool> _tools = new List<Tool>()
    {
        new Tool(ToolType.Lynlås, "lille", 43, "fuck", "mere fuck", Brand.PetitKnit, 23),
        new Tool(ToolType.Lynlås, "lille", 43, "fuck", "mere fuck", Brand.PetitKnit, 23),
        new Tool(ToolType.Lynlås, "lille", 43, "fuck", "mere fuck", Brand.PetitKnit, 23)
    };
    internal static List<Tool> GetAllToolProducts()
    {
        return _tools; 
    }
}
