using Microsoft.EntityFrameworkCore;
using NygarnDemo.Enums;
using NygarnDemo.Models;

namespace NygarnDemo.EFDbContext
{
	public class HookDbContext : DbContext
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
			modelBuilder.Entity<HookDbContext>().ToTable("Hook")
				.HasData(
				new CrochetHook()
				{
					Id = 1,
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
					Id = 2,
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
					Id = 3,
					Price = 599,
					Name = "KnitPro",
					Description = "Den bedste hækle nål",
					Brand = "PetitKnit",
					Amount = 1,
					Material = NeedleAndHookMaterial.plastik,
					Size = Size.Size60mm,
					Set = false

				}

				);

		}

		public DbSet<CrochetHook> CrochetHook { get; set; }
	}
}
