using Microsoft.AspNetCore.Mvc;
using NygarnDemo.Enums;
using System;
using System.ComponentModel.DataAnnotations;
namespace NygarnDemo.Models;

public class KnittingNeedle : Product
{

    [Display(Name = "Materiale")]
    [Required(ErrorMessage = "Der skal vælges materiale")]
    public NeedleAndHookMateriale Materiale { get; set; }

    [Display(Name = "Type")]
    [Required(ErrorMessage = "Vælg en type")] 
    public NeedleType Type { get; set; }
    [Display(Name = "Størrelse")]
    [Required(ErrorMessage = "Vælg en størrelse")]
    public Size Size { get; set; }

    [BindProperty]
    public bool Set { get; set; }


    public KnittingNeedle(NeedleAndHookMateriale materiale, Size size, NeedleType type,  string name, string description, Brand brand, int amount, decimal price, bool set) : base(price, name, description, brand, amount)
    {
        Price = price;
        Size = size;
        Type = type;
        Name = name;
        Description = description;
        Brand = brand;
        Materiale = materiale;
        Set = set;

    }
    public KnittingNeedle(decimal price, string name, string description, Brand brand, int amount) : base(price, name, description, brand, amount)
    {
        Materiale = 0;
        Price = 0;
        Type = 0; 
        Size = 0;
        Name = "";
        Description = "";
        Brand = 0;
        Set = false;
    }
}
