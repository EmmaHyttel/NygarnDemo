using NygarnDemo.Enums;
using System.ComponentModel.DataAnnotations;
using Color = NygarnDemo.Enums.Color;

namespace NygarnDemo.Models;

public class Tool : Product
{
    [Display(Name = "Type")]
    [Required(ErrorMessage = "Vælg en type")]
    public ToolType Type { get; set; }


    [Display(Name = "Størrelse")]
    [Required(ErrorMessage = "Vælg størrelse")]
    public string Size { get; set; }

    public Tool(ToolType type, string size, decimal price, string name, string description, Brand brand,
        int amount, int productId) : base(price, name, description, brand, amount, productId)
    {
        Type = type;
        Size = size;  
    }

    public Tool() : base()
    {
        Type = 0;
        Size = "";
    }
}


