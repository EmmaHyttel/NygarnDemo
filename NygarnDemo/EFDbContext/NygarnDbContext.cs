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
    //public DbSet<OrderLine> OrderLine { get; set; }
    public DbSet<KnittingNeedle> KnittingNeedle { get; set; }
    public DbSet<CrochetHook> CrochetHook { get; set; }
    //public DbSet<Order> Order { get; set; }

    private User ReturnUserWithHashedPassword(User user)
    {
        var passwordHasher = new PasswordHasher<string>();

        user.Password = passwordHasher.HashPassword(user.UserName, user.Password);

        return user;
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Yarn>().ToTable("YarnTable")
			.HasData(
				new Yarn()
				{
					ProductId = 1,
					Price = 99,
					Name = "Luksus garn",
					Description = "Meget luksus garn, ikke egnet til påklædning.",
					Brand = "Sandnes",
					Amount = 10,
					Color = Color.Rød,
					KnittingTension = "KnittingTension10mX10cm",
					Yardage = "Yardage400mPr50g",
					Material = Material.Alpakka,
					Weight = 100,
					SuggestedNeedleSize = Size.Size25mm,
					MachineWash = false
				},
				new Yarn()
				{
					ProductId = 2,
					Price = 49,
					Name = "Saga",
					Description = "Meget luksus garn, ikke egnet til påklædning.",
					Brand = "Sandne",
					Amount = 10,
					Color = Color.Rød,
					KnittingTension = "KnittingTension10mX10cm",
					Yardage = "Yardage400mPr50g",
					Material = Material.Alpakka,
					Weight = 100,
					SuggestedNeedleSize = Size.Size25mm,
					MachineWash = false
				},
				new Yarn()
				 {
					 ProductId = 3,
					 Color = Color.Beige,
					 KnittingTension = "knittingTension21mX10cm",
					 Yardage = "Yardage215mPr50g",
					 Material = Material.Mohair,
					 Weight = 50,
					 SuggestedNeedleSize = Size.Size20mm,
					 MachineWash = true,
					 Price = 79,
					 Name = "MyHair",
					 Description = "Vildt lækkert mohair garn til din næste sweater",
					 Brand = "Sandnes",
					 Amount = 1
				},
				new Yarn()
				{
					ProductId = 4,
					Color = Color.Beige,
					KnittingTension = "knittingTension25mX10cm",
					Yardage = "Yardage300mPr50g",
					Material = Material.Alpakka,
					Weight = 50,
					SuggestedNeedleSize = Size.Size30mm,
					MachineWash = true,
					Price = 69,
					Name = "MaLamaa",
					Description = "Vildt lækkert alpakka garn til dit næste tørklæde",
					Brand = "Petitknit",
					Amount = 1
				},
				new Yarn()
				{
					ProductId = 5,
					Color = Color.Rød,
					KnittingTension = "knittingTension30mX10cm",
					Yardage = "Yardage400mPr50g",
					Material = Material.Silke,
					Weight = 50,
					SuggestedNeedleSize = Size.Size40mm,
					MachineWash = false,
					Price = 75,
					Name = "SlikkeSilke",
					Description = "Vildt lækkert silke garn til dit næste hårbånd",
					Brand = "Petitknit",
					Amount = 1
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

        modelBuilder.Entity<Tool>().ToTable("ToolTable")
                .HasData(
                    new Tool()
                    {
                        ProductId = 6,
                        Price = 30,
                        Name = "Babyknap",
                        Description = "Rigtig fine små knapper, der passer perfekt til lukningen på en bodystocking",
                        Brand = "PetitKnit",
                        Amount = 12,
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
                        Amount = 1,
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
                        Amount = 1,
                        Type = "Fyld",
                        Size = "100 gram"
                    }
                    );

        modelBuilder.Entity<KnittingNeedle>().ToTable("KnittingNeedleTable")
                 .HasData(
                     new KnittingNeedle()
                     {
                         ProductId = 9,
                         Price = 149,
                         Name = "KnitPro",
                         Description = "Gode til alt",
                         Brand = "KnitPro",
                         Amount = 1,
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
                         Amount = 1,
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
                         Amount = 1,
                         Type = NeedleType.Rundpinde,
                         Material = NeedleAndHookMaterial.plastik,
                         Size = Size.Size30mm,
                         Set = true
                     }
                     );

        modelBuilder.Entity<CrochetHook>().ToTable("CrochetHookTable")
                .HasData(
                new CrochetHook()
                {
                    ProductId = 12,
                    Price = 49,
                    Name = "Knyt",
                    Description = "Gode til alt",
                    Brand = "PetitKnit",
                    Amount = 1,
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
                    Amount = 2,
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
                    Amount = 1,
                    Material = NeedleAndHookMaterial.plastik,
                    Size = Size.Size60mm,
                    Set = false

                }

                );
        //modelBuilder.Entity<OrderLine>().ToTable("OrderLineTable")
        //        .HasKey(ol => new { ol.OrderId, ol.ProductId });

        //modelBuilder.Entity<OrderLine>()
        //    .HasOne(ol => ol.Order)
        //    .WithMany(o => o.OrderLine)
        //    .HasForeignKey(ol => ol.OrderId);
        //    .OnDelete(DeleteBehavior.Cascade);

        //modelBuilder.Entity<OrderLine>()
        //    .HasOne(ol => ol.Yarn)
        //    .WithMany(y => y.OrderLine)
        //    .HasForeignKey(ol => ol.ProductId)
        //    .OnDelete(DeleteBehavior.Restrict);

        //modelBuilder.Entity<OrderLine>()
        //    .HasOne(ol => ol.Tool)
        //    .WithMany(t => t.OrderLine)
        //    .HasForeignKey(ol => ol.ProductId)
        //    .OnDelete(DeleteBehavior.Restrict);

        //modelBuilder.Entity<OrderLine>()
        //    .HasOne(ol => ol.KnittingNeedle)
        //    .WithMany(kn => kn.OrderLine)
        //    .HasForeignKey(ol => ol.ProductId)
        //    .OnDelete(DeleteBehavior.Restrict);

        //modelBuilder.Entity<OrderLine>()
        //    .HasOne(ol => ol.CrochetHook)
        //    .WithMany(ch => ch.OrderLine)
        //    .HasForeignKey(ol => ol.ProductId)
        //    .OnDelete(DeleteBehavior.Restrict);

        //modelBuilder.Entity<OrderLine>()
        //    .HasOne(ol => ol.Pattern)
        //    .WithMany(p => p.OrderLineTable)
        //    .HasForeignKey(ol => ol.ProductId)
        //    .OnDelete(DeleteBehavior.Restrict);
    }
}
