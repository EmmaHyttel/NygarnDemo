using NygarnDemo.Enums;
using System.ComponentModel.DataAnnotations;
using Color = NygarnDemo.Enums.Color;

namespace NygarnDemo.Models;

public class Tool : Product
{
    [Display(Name = "Vælg mærke")]
    [Required(ErrorMessage = "Der skal vælges et mærke")]
    public Brand brand { get; set; }

    [Display(Name = "Type")]
    [Required(ErrorMessage = "Vælg en type")]
    public ToolType Type { get; set; }


    [Display(Name = "Størrelse")]
    [Required(ErrorMessage = "Vælg størrelse")]
    public string Size { get; set; }

    public Tool( string color, ToolType type, string size, decimal price, string name, string description, Brand brand, 
        int amount) : base(price, name, description, brand, amount)
    {
        Brand = brand; 
        Type = type;
        Size = size;
        Color = color;
        
    }

    public Tool(decimal price, string name, string description, Brand brand, int amount) : 
        base(price, name, description, brand, amount)
    {
        //Brand = 0;
        //Type = 0;
        //Size = "";
    }
}


