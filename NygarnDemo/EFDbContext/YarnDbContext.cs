using Microsoft.EntityFrameworkCore;
using NygarnDemo.Models;

namespace NygarnDemo.EFDbContext;

public class YarnDbContext : DbContext
{
	protected YarnDbContext()
	{
	}

	protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        //options.UseSqlServer(@"Data Source=mssql11.unoeuro.com;Initial Catalog=nygarndemo_dk_db_the_database; Integrated Security=True; Connect Timeout=30; Encrypt=False");
        //options.UseSqlServer(@"Data Source=mssql11.unoeuro.com;User ID=nygarndemo_dk;Password=drHmxBw4p6nkFcha2Abt;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False Connect Timeout=30; Encrypt=False");
        options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LocalNygarn;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Yarn>().ToTable("Yarn")
            .HasKey(e => e.ProductId);
    }


    public DbSet<Yarn> YarnProducts { get; set; }
    public DbSet<User> Users { get; set; }

}
