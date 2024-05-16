using Microsoft.EntityFrameworkCore;
using NygarnDemo.Enums;
using NygarnDemo.Models;

namespace NygarnDemo.EFDbContext
{
    public class ToolDbContext : DbContext
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
            modelBuilder.Entity<Tool>().ToTable("Tools")
                .HasData(
                    new Tool()
                    {
                        ProductId = 1,
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
                        ProductId = 2,
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
                        ProductId = 3,
                        Price = 40,
                        Name = "Bamsefyld",
                        Description = "Super blødt bamsefyld til dit næste hækleprojekt",
                        Brand = "Sandnes",
                        Amount = 1,
                        Type = "Fyld",
                        Size = "100 gram"
                    }

                    );
        }

        public DbSet<Tool> ToolProducts { get; set; }
    }
}
