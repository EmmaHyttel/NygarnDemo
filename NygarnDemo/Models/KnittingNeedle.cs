﻿using Microsoft.AspNetCore.Mvc;
using NygarnDemo.Enums;
using System;
using System.ComponentModel.DataAnnotations;
namespace NygarnDemo.Models;

public class KnittingNeedle : Product
{

    [Display(Name = "Material")]
    [Required(ErrorMessage = "Der skal vælges material")]
    public NeedleAndHookMaterial Material { get; set; }

    [Display(Name = "Type")]
    [Required(ErrorMessage = "Vælg en type")] 
    public NeedleType Type { get; set; }
    [Display(Name = "Størrelse")]
    [Required(ErrorMessage = "Vælg en størrelse")]
    public Size Size { get; set; }

    public bool Set { get; set; }


    public KnittingNeedle(NeedleAndHookMaterial material, Size size, NeedleType type,  string name, string description, 
        string brand, int amount, decimal price, bool set) : base(price, name, description, brand)
    {
        Material = material;
        Set = set;
        Size = size;
    }
    public KnittingNeedle() : base()
    {
        Material = 0;
        Size = 0;
        Set = false;
    }
}
