using Microsoft.EntityFrameworkCore;
using NygarnDemo.Models;

namespace NygarnDemo.EFDbContext
{
    public class PersonDbContext : DbContext
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
            modelBuilder.Entity<Person>().ToTable("Person")
                .HasData(
                    new Person()
                    {
                        Id = 1,
                        UserName = "admin",
                        Name = "NEM",
                        LastName = "HARD",
                        Password = "secretzz",
                        Address = "En sej vej",
                        Phone = "69696969",
                        Email = "nem@hard.com"
                    });
        }
        public DbSet<Person> Person { get; set; }
    }
}
