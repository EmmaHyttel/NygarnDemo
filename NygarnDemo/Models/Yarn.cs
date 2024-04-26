using NygarnDemo.Enums;
using System.ComponentModel.DataAnnotations;

namespace NygarnDemo.Models;

public class Yarn : Product
{

    [Display(Name = "Garnets farve")]
    [Required(ErrorMessage = "Der skal angives en farve til garn")]
    public Color Color { get; set; }

    [Display(Name = "Garnets strikkefasthed")]
    [Required(ErrorMessage = "Der skal angives en strikkefasthed til garn")]
    public string KnittingTension { get; set; }

    [Display(Name = "Garnets løbelængde")]
    [Required(ErrorMessage = "Der skal angives en løbelængde til garn")]
    public string Yardage { get; set; }

    [Display(Name = "Garnmateriale")]
    [Required(ErrorMessage = "Der skal angives et material til garn")]
    public string Material { get; set; }

    [Display(Name = "Garnets vægt")]
    [Required(ErrorMessage = "Der skal angives en vægt til garn")]
    public int Weight { get; set; }

    [Display(Name = "Anbefalede pinde")]
    [Required(ErrorMessage = "Der skal angives en anbefalet pind til garn")]
    public string Needles { get; set; }

    [Display(Name = "Maskinevask")]
    [Required(ErrorMessage = "Der skal angives en anbefalet maskinevask til garn")]
    public string MachineWash { get; set; }

    public Yarn(Color color, string knittingTension, string yardage, string material, int weight, string needles, string machineWash, decimal price, string name, string description, string brand, int amount) : base(price, name, description, brand, amount)
    {
        Color = color;
        KnittingTension = knittingTension;
        Yardage = yardage;
        Material = material;
        Weight = weight;
        Needles = needles;
        MachineWash = machineWash;
    }

    public Yarn(decimal price, string name, string description, string brand, int amount) : base(price, name, description, brand, amount)
    {
        Color = 0;
        KnittingTension = "";
        Yardage = "";
        Material = "";
        Weight = 1;
        Needles = "";
        MachineWash = "";
    }
}
