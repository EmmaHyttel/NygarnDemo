using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NygarnDemo.Enums;
using NygarnDemo.Models;

namespace NygarnDemo.EFDbContext;

public class NygarnDbContext : DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder options)
	{
		options.UseSqlServer(@"Data Source=mssql17.unoeuro.com;
							Initial Catalog=nygarndemo_dk_db_projekt;
							User ID=nygarndemo_dk;
							Password=drHmxBw4p6nkFcha2Abt;
							Connect Timeout=30;Encrypt=True;
							Trust Server Certificate=True;
							Application Intent=ReadWrite;
							Multi Subnet Failover=False;
							Connect Timeout=30; 
							Encrypt=False"
		);
	}
    public DbSet<Yarn> Yarn { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Tool> Tool { get; set; }
    public DbSet<KnittingNeedle> KnittingNeedle { get; set; }
    public DbSet<CrochetHook> CrochetHook { get; set; }
    //public DbSet<ShoppingCartLine> ShoppingCartLine { get; set; }
    //public DbSet<WishList> WishList { get; set; }


    private User ReturnUserWithHashedPassword(User user)
    {
        var passwordHasher = new PasswordHasher<string>();

        user.Password = passwordHasher.HashPassword(user.UserName, user.Password);

        return user;
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Yarn>().ToTable("Yarn")
            .HasData(
                new Yarn()
                {
                    ProductId = 1,
                    Price = 57,
                    Name = "Double Sunday",
                    Description = "100% merinould uden superwashbehandling \nKan maskinvaskes på 30 grader uldprogram",
                    Brand = "Sandnes garn",
                    Color = Color.Brun,
                    KnittingTension = "21-22 masker = 10 cm",
                    Yardage = "108 m",
                    Material = Material.Merinould,
                    Weight = 50,
                    SuggestedNeedleSize = "pind 3.5-4",
                    MachineWash = true
                },
                new Yarn()
                {
                    ProductId = 2,
                    Price = 75,
                    Name = "Tynn Silk Mohair",
                    Description = "57% mohair, 15% uld og 28% silke \nKan maskinvaskes ved 30 grader (uldprogram)",
                    Brand = "Sandnes garn",
                    Color = Color.Beige,
                    KnittingTension = "24 m x 18 p = 10 x 10 cm",
                    Yardage = "212 m",
                    Material = Material.Mohair,
                    Weight = 25,
                    SuggestedNeedleSize = "pind 4-5",
                    MachineWash = true
                },
                new Yarn()
                {
                    ProductId = 3,
                    Price = 75,
                    Name = "Tynn Silk Mohair",
                    Description = "57% mohair, 15% uld og 28% silke \nKan maskinvaskes ved 30 grader (uldprogram)",
                    Brand = "Sandnes garn",
                    Color = Color.Blå,
                    KnittingTension = "24 m x 18 p = 10 x 10 cm",
                    Yardage = "212 m",
                    Material = Material.Mohair,
                    Weight = 25,
                    SuggestedNeedleSize = "pind 3-5",
                    MachineWash = true
                },
                new Yarn()
                {
                    ProductId = 4,
                    Color = Color.Beige,
                    KnittingTension = "knittingTension25mX10cm",
                    Yardage = "Yardage300mPr50g",
                    Material = Material.Alpakka,
                    Weight = 50,
                    SuggestedNeedleSize = "pind 6-8",
                    MachineWash = true,
                    Price = 69,
                    Name = "MaLamaa",
                    Description = "Vildt lækkert alpakka garn til dit næste tørklæde",
                    Brand = "Petitknit",
                },
                new Yarn()
                {
                    ProductId = 5,
                    Color = Color.Rød,
                    KnittingTension = "knittingTension30mX10cm",
                    Yardage = "Yardage400mPr50g",
                    Material = Material.Silke,
                    Weight = 50,
                    SuggestedNeedleSize = "pind 4-5",
                    MachineWash = false,
                    Price = 75,
                    Name = "SlikkeSilke",
                    Description = "Vildt lækkert silke garn til dit næste hårbånd",
                    Brand = "Petitknit",
                }
                );

        modelBuilder.Entity<User>().ToTable("User")
            .HasData(
             ReturnUserWithHashedPassword(
                new User()
                {
                    Id = 1,
                    UserName = "admin",
                    Name = "NEM",
                    LastName = "HARD",
                    Password = "secretzz",
                    Address = "En sej gade",
                    Phone = "69696969",
                    Email = "nem_hard@garn.dk"
                }),
            ReturnUserWithHashedPassword(
                new User()
                {
                    Id = 2,
                    UserName = "EmmaStrikker123",
                    Name = "Emma",
                    LastName = "Hyttel",
                    Password = "maiv",
                    Address = "Vejgade 1",
                    Phone = "12345678",
                    Email = "emmastrikker@garn.dk"
                }),
                ReturnUserWithHashedPassword(
              new User()
              {
                  Id = 3,
                  UserName = "MaiStrikker123",
                  Name = "Mai",
                  LastName = "Dinh",
                  Password = "maiv",
                  Address = "Vejgade 2",
                  Phone = "23456789",
                  Email = "maistrikker@garn.dk"
              }),
                ReturnUserWithHashedPassword(
              new User()
              {
                  Id = 4,
                  UserName = "NannaHækler123",
                  Name = "Nanna",
                  LastName = "Rister",
                  Password = "maiv",
                  Address = "Vejgade 3",
                  Phone = "34567891",
                  Email = "nannahækler@garn.dk"
              })
                );

        modelBuilder.Entity<Tool>().ToTable("Tool")
                .HasData(
                    new Tool()
                    {
                        ProductId = 6,
                        Price = 30,
                        Name = "Babyknap",
                        Description = "Rigtig fine små knapper, der passer perfekt til lukningen på en bodystocking",
                        Brand = "PetitKnit",
                        Type = "Knapper",
                        Size = "5 mm"
                    },
                    new Tool()
                    {
                        ProductId = 7,
                        Price = 25,
                        Name = "Målebånd",
                        Description = "Fuldstændig præcis målebånd",
                        Brand = "PetitKnit",
                        Type = "Målebånd",
                        Size = "100 cm"
                    },
                    new Tool()
                    {
                        ProductId = 8,
                        Price = 40,
                        Name = "Bamsefyld",
                        Description = "Super blødt bamsefyld til dit næste hækleprojekt",
                        Brand = "Sandnes",
                        Type = "Fyld",
                        Size = "100 gram"
                    }
                    );

        modelBuilder.Entity<KnittingNeedle>().ToTable("KnittingNeedle")
                 .HasData(
                     new KnittingNeedle()
                     {
                         ProductId = 9,
                         Price = 149,
                         Name = "KnitPro",
                         Description = "Gode til alt",
                         Brand = "KnitPro",
                         Type = NeedleType.Rundpinde,
                         Material = NeedleAndHookMaterial.plastik,
                         Size = Size.Size30mm,
                         Set = true
                     },
                     new KnittingNeedle()
                     {
                         ProductId = 10,
                         Price = 499,
                         Name = "Hot",
                         Description = "Dejlig store",
                         Brand = "KnitPro",
                         Type = NeedleType.Jumperpinde,
                         Material = NeedleAndHookMaterial.bambus,
                         Size = Size.Size40mm,
                         Set = true
                     },
                     new KnittingNeedle()
                     {
                         ProductId = 11,
                         Price = 140,
                         Name = "KnitPro",
                         Description = "Gode til alt",
                         Brand = "KnitPro",
                         Type = NeedleType.Rundpinde,
                         Material = NeedleAndHookMaterial.plastik,
                         Size = Size.Size30mm,
                         Set = true
                     }
                     );

        modelBuilder.Entity<CrochetHook>().ToTable("CrochetHook")
                .HasData(
                new CrochetHook()
                {
                    ProductId = 12,
                    Price = 49,
                    Name = "Knyt",
                    Description = "Gode til alt",
                    Brand = "PetitKnit",
                    Material = NeedleAndHookMaterial.plastik,
                    Size = Size.Size50mm,
                    Set = true
                },

                new CrochetHook()
                {
                    ProductId = 13,
                    Price = 149,
                    Name = "KnitPro",
                    Description = "Gode til alt",
                    Brand = "PetitKnit",
                    Material = NeedleAndHookMaterial.plastik,
                    Size = Size.Size30mm,
                    Set = false
                },

                new CrochetHook()
                {
                    ProductId = 14,
                    Price = 599,
                    Name = "NeedlePickled",
                    Description = "",
                    Brand = "PetitKnit",
                    Material = NeedleAndHookMaterial.plastik,
                    Size = Size.Size60mm,
                    Set = false

                }
                );

    }
}
