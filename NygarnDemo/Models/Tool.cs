using NygarnDemo.Enums;
using System.ComponentModel.DataAnnotations;
using Color = NygarnDemo.Enums.Color;

namespace NygarnDemo.Models;

public class Tool : Product
{
    [Display(Name = "Type")]
    [Required(ErrorMessage = "Vælg en type")]
    public string Type { get; set; }


    [Display(Name = "Størrelse")]
    [Required(ErrorMessage = "Vælg størrelse")]
    public string Size { get; set; }

    public Tool(string type, string size, decimal price, string name, string description, string brand,
        int amount) : base(price, name, description, brand, amount)
    {
        Type = type;
        Size = size;  
    }

    public Tool() : base()
    {
        Type = "";
        Size = "";
    }
}


