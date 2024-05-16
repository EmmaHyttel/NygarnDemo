using Microsoft.EntityFrameworkCore;
using NygarnDemo.Enums;
using NygarnDemo.Models;

namespace NygarnDemo.EFDbContext
{
    public class NeedleDbContext : DbContext
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
            modelBuilder.Entity<KnittingNeedle>().ToTable("KnittingNeedles")
                .HasData(
                    new KnittingNeedle()
                    {
                        ProductId = 1,
                        Price = 149,
                        Name = "KnitPro",
                        Description = "Gode til alt",
                        Brand = "PetitKnit",
                        Amount = 2,
                        Type = NeedleType.Rundpinde,
                        Material = NeedleAndHookMaterial.plastik,
                        Size = Size.Size30mm,
                        Set = true
                    },
                    new KnittingNeedle()
                    {
                        ProductId = 2,
                        Price = 499,
                        Name = "Hot",
                        Description = "Dejlig store",
                        Brand = "PetitKnit",
                        Amount = 2,
                        Type = NeedleType.Jumperpinde,
                        Material = NeedleAndHookMaterial.bambus,
                        Size = Size.Size40mm,
                        Set = true
                    },
                    new KnittingNeedle()
                    {
                        ProductId = 3,
                        Price = 140,
                        Name = "KnitPro",
                        Description = "Gode til alt",
                        Brand = "PetitKnit",
                        Amount = 2,
                        Type = NeedleType.Rundpinde,
                        Material = NeedleAndHookMaterial.plastik,
                        Size = Size.Size30mm,
                        Set = true
                    }

                    );

        }

        public DbSet<KnittingNeedle> KnittingNeedles { get; set; }
    }
}
