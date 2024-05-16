using Microsoft.EntityFrameworkCore;
using NygarnDemo.Models;

namespace NygarnDemo.EFDbContext
{
    public class OrderLineDbContext : DbContext
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
            modelBuilder.Entity<OrderLine>()
                .HasKey(ol => new { ol.OrderId, ol.ProductId });

            modelBuilder.Entity<OrderLine>()
                .HasOne(ol => ol.Order)
                .WithMany(o => o.OrderLines)
                .HasForeignKey(ol => ol.OrderId);

            modelBuilder.Entity<OrderLine>()
                .HasOne(ol => ol.Yarn)
                .WithMany(y => y.OrderLines)
                .HasForeignKey(ol => ol.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderLine>()
                .HasOne(ol => ol.Tool)
                .WithMany(t => t.OrderLines)
                .HasForeignKey(ol => ol.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderLine>()
                .HasOne(ol => ol.KnittingNeedle)
                .WithMany(kn => kn.OrderLines)
                .HasForeignKey(ol => ol.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderLine>()
                .HasOne(ol => ol.CrochetHook)
                .WithMany(ch => ch.OrderLines)
                .HasForeignKey(ol => ol.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderLine>()
                .HasOne(ol => ol.Pattern)
                .WithMany(p => p.OrderLines)
                .HasForeignKey(ol => ol.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            // Tilføjelse af nødvendig konfiguration for fremmednøgler
        }


        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Yarn> Yarns { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<KnittingNeedle> KnittingNeedles { get; set; }
        public DbSet<CrochetHook> CrochetHooks { get; set; }
        public DbSet<Pattern> Patterns { get; set; }


    }
}
