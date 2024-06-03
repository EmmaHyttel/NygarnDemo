using NygarnDemo.Enums;
using NygarnDemo.Helpers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NygarnDemo.Models;

public abstract class Product
{
	//private static ProductIdGenerator _idGenerator = new ProductIdGenerator();
    [Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int ProductId { get; set; }

    [Display(Name = "Pris")]
    [Required(ErrorMessage = "Der skal angives en pris")]
    public decimal Price { get; set; }

    [Display(Name = "Produkt Navn")]
    [Required(ErrorMessage = "Produkt skal have et navn")]
    [StringLength(100)]
    public string Name { get; set; } 

    [Display(Name = "Produkt Beskrivelse")]
    [Required(ErrorMessage = "Produkt skal have en beskrivelse")]
    [StringLength(500)]
    public string Description { get; set; }

    [Display(Name = "Brand")]
    [Required(ErrorMessage = "Produkt Brand skal anføres")]
    //[StringLength(100)]
    public string Brand { get; set; }
    public int Amount { get; set; }

    public string ProductImage { get; set; }

    public Product(decimal price, string name, string description, string brand, int amount)
    {
        Price = price;
        Name = name;
        Description = description;
        Brand = brand;
        Amount = amount;
        ProductId = 0;
        ProductImage = "";
    }

    public Product()
    {
        Price = 0;
        Name = "";
        Description = "";
        Brand = "";
        Amount = 1;
        ProductId = 0;
        ProductImage = "";
    }

    //private string GenerateProductId()
    //{
    //    return _idGenerator.GenerateProductId();
    //}

}
