using NygarnDemo.Enums;
using NygarnDemo.Helpers;
using System.ComponentModel.DataAnnotations;

namespace NygarnDemo.Models;

public class Product
{
	private static ProductIdGenerator _idGenerator = new ProductIdGenerator();

	public string ProductId { get; set; }

    [Display(Name = "Pris")]
    [Required(ErrorMessage = "Der skal angives en pris")]
    public decimal Price { get; set; }

    [Display(Name = "Produkt Navn")]
    [Required(ErrorMessage = "Produkt skal have et navn")]
    [StringLength(100)]
    public string Name { get; set; }

    [Display(Name = "Produkt Beskrivelse")]
    [Required(ErrorMessage = "Produkt skal have et navn")]
    [StringLength(500)]
    public string Description { get; set; }

    [Display(Name = "Brand")]
    [Required(ErrorMessage = "Produkt Brand skal anføres")]
    [StringLength(100)]
    public Brand Brand { get; set; }
    public int Amount { get; set; }

    public Product(decimal price, string name, string description, Brand brand, int amount)
    {
        ProductId = GenerateProductId();
        Price = price;
        Name = name;
        Description = description;
        Brand = brand;
        Amount = amount;
    }

    public Product()
    {
        ProductId = GenerateProductId();
        Price = 0;
        Name = "testProdukt";
        Description = "Beskrivelse";
        Brand = 0;
        Amount = 0;
    }

    private string GenerateProductId()
    {
        return _idGenerator.GenerateProductId();
    }

}
