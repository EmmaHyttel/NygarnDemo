using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace NygarnDemo.Models;

public class CrochetHook : Product
{
    [Display(Name = "Materiale" )]
    [Required(ErrorMessage = "Der skal vælges materiale")]
    public string Materiale { get; set; }
    [Display(Name = "Størrelse")]
    [Required(ErrorMessage = "Vælg en størrelse")]
    public double Size { get; set; }
    public bool Set { get; set; }


    public CrochetHook(string materiale, double size, decimal price, string name, string description, string brand, int amount) : base(price, name, description, brand, amount)
    {
        Materiale = materiale; 
        Size = size;
        Set = set;
    }

    public CrochetHook(decimal price, string name, string description, string brand, int amount) : base(price, name, description, brand, amount)
    {
        Materiale = "default";
        Size = 0;
        Set = set;
    }
}
