namespace NygarnDemo.MockData;
using NygarnDemo.Enums;
using NygarnDemo.Models;
using System;

public class MockTool
{
    private static List<Tool> _tools = new List<Tool>()
    {
        new Tool("Lynlås", "lille", 43, "fuck", "mere fuck", "Petitknit", 23),
        new Tool("Lynlås", "lille", 43, "fuck", "mere fuck", "Petitknit", 23),
        new Tool("Lynlås", "lille", 43, "fuck", "mere fuck", "Petitknit", 23)
    };
    internal static List<Tool> GetAllToolProducts()
    {
        return _tools; 
    }
}
