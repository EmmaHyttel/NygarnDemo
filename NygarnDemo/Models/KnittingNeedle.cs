using NygarnDemo.Enums;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace NygarnDemo.Models;

public class KnittingNeedle : Product
{

    [Display(Name = "Materiale")]
    [Required(ErrorMessage = "Der skal vælges materiale")]
    public string Materiale { get; set; }

    [Display(Name = "Type")]
    [Required(ErrorMessage = "Vælg en type")] 
    public string Type { get; set; }
    [Display(Name = "Størrelse")]
    [Required(ErrorMessage = "Vælg en størrelse")]
    public double Size { get; set; }
   
    public bool Set { get; set; }


    public KnittingNeedle(string materiale, string type, double size, decimal price, string name, string description, Brand brand, int amount, bool set) : base(price, name, description, brand, amount)
    {
        Materiale = materiale;
        Type = type; 
        Size = size;
        Set = set;
    }

    public KnittingNeedle(decimal price, string name, string description, Brand brand, int amount) : base(price, name, description, brand, amount)
    {
        Materiale = "default";
        Type = "default";
        Size = 0;
        Set = false;
    }
}
