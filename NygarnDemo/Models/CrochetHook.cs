using Microsoft.AspNetCore.Mvc;
using NygarnDemo.Enums;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using Size = NygarnDemo.Enums.Size;

namespace NygarnDemo.Models;

public class CrochetHook : Product
{
   
    [Display(Name = "Materiale" )]
    [Required(ErrorMessage = "Der skal vælges materiale")]
    public NeedleAndHookMateriale Materiale { get; set; }

    [Display(Name = "Størrelse")]
    [Required(ErrorMessage = "Vælg en størrelse")]
    public Size Size { get; set; }

    [Display(Name = "Sæt")]
    [Required(ErrorMessage = "Vælg sæt")]
    public bool Set { get; set; }


    public CrochetHook(NeedleAndHookMateriale materiale, Size size, string name, string description, Brand brand, int amount, decimal price, bool set) : base(price, name, description, brand, amount)
    {
        Price = price;
        Size = size;
        Name = name;
        Description = description;
        Brand = brand;
        Materiale = materiale;
        Set = set;

    }


    public CrochetHook(decimal price, string name, string description, Brand brand, int amount) : base(price, name, description, brand, amount)
    {
        Materiale = 0;
        Price = 0;
        Size = 0;
        Name = "";
        Description = "";
        Brand = 0;
        Set = false;
    }

}
