using Microsoft.AspNetCore.Mvc;
using NygarnDemo.Enums;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using Size = NygarnDemo.Enums.Size;

namespace NygarnDemo.Models;

public class CrochetHook : Product
{
   
    [Display(Name = "Material" )]
    [Required(ErrorMessage = "Der skal vælges material")]
    public NeedleAndHookMaterial Material { get; set; }

    [Display(Name = "Størrelse")]
    [Required(ErrorMessage = "Vælg en størrelse")]
    public Size Size { get; set; }

    [Display(Name = "Sæt")]
    [Required(ErrorMessage = "Vælg sæt")]
    public bool Set { get; set; }


    public CrochetHook(NeedleAndHookMaterial material, Size size, string name, string description, string brand, 
        int amount, decimal price, bool set) : base(price, name, description, brand, amount)
    {
        Material = material;
        Set = set;
        Size = size;
    }
    public CrochetHook() : base()
    {
        Material = 0;
        Brand = "";
        Set = false;
    }

    public ICollection<OrderLine> OrderLines { get; set; }


}
