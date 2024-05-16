using Microsoft.EntityFrameworkCore;
using NygarnDemo.Enums;
using NygarnDemo.Models;

namespace NygarnDemo.EFDbContext;

public class YarnDbContext : DbContext
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
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Yarn>().ToTable("YarnProducts")
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
					Size = Size.Size25mm,
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
					Size = Size.Size25mm,
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
					 Size = Size.Size20mm,
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
					Size = Size.Size30mm,
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
					Size = Size.Size40mm,
					MachineWash = false,
					Price = 75,
					Name = "SlikkeSilke",
					Description = "Vildt lækkert silke garn til dit næste hårbånd",
					Brand = "Petitknit",
					Amount = 1
				}
				);
	}

   
    public DbSet<Yarn> YarnProducts { get; set; }
 
}
