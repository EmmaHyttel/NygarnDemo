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
    public Material Material { get; set; }

    [Display(Name = "Garnets vægt")]
    [Required(ErrorMessage = "Der skal angives en vægt til garn")]
    public int Weight { get; set; }

    [Display(Name = "Anbefalede pinde")]
    [Required(ErrorMessage = "Der skal angives en anbefalet pind til garn")]
    public string SuggestedNeedleSize { get; set; }

    [Display(Name = "Maskinevask")]
    [Required(ErrorMessage = "Der skal angives en anbefalet maskinevask til garn")]
    public bool MachineWash { get; set; }

    public Yarn(Color color, string knittingTension, string yardage, Material material, int weight, string size, 
        bool machineWash, decimal price, string name, string description, string brand) : 
        base(price, name, description, brand)
    {
        Color = color;
        KnittingTension = knittingTension;
        Yardage = yardage;
        Material = material;
        Weight = weight;
        SuggestedNeedleSize = size;
        MachineWash = machineWash;
        
    }

    public Yarn() : base()
    {
        Color = 0;
        KnittingTension = "";
        Yardage = "";
        Material = 0;
        Weight = 1;
        SuggestedNeedleSize = "";
        MachineWash = false;
        
    }

}
