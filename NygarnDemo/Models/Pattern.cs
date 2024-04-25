﻿using NygarnDemo.Enums;

namespace NygarnDemo.Models;
public class Pattern : Product
{
    public Pattern(string designer, string difficultyLevel, Category category, Fits fits, bool freePattern, decimal price, 
        string name, string description, string brand, int amount) : base(price, name, description, brand, amount)
    {
        Designer = designer;
        DifficultyLevel = difficultyLevel;
        Category = category;
        Fits = fits;
        FreePattern = false;
    }

    public string? Designer { get; set; }
    public string? DifficultyLevel { get; set; }
    public Category Category { get; set; }
    public Fits Fits { get; set; }
    public bool FreePattern { get; set; }

    public Pattern(decimal price, string name, string description, string brand, int amount) : base(price, name, description, brand, amount)
    {
        Designer = "";
        DifficultyLevel = "";
        Category = 0;
        Fits = 0;
        FreePattern = false;
    }
}
