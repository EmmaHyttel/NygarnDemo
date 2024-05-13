using Microsoft.EntityFrameworkCore;
using NygarnDemo.Enums;
using NygarnDemo.Models;

namespace NygarnDemo.EFDbContext
{
    public class UserDbContext : DbContext
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
            modelBuilder.Entity<User>().ToTable("Users")
                .HasData(
                    new User()
                    {
                     Id = 1,
                     UserName = "EmmaStrikker123",
                     Name = "Emma",
                     LastName = "Hyttel",
                     Password = "maiv",
                     Address = "Vejgade 1",
                     Phone = "12345678",
                     Email = "emmastrikker@garn.dk"
                    },
                  new User()
                  {
                      Id = 2,
                      UserName = "MaiStrikker123",
                      Name = "Mai",
                      LastName = "Dinh",
                      Password = "maiv",
                      Address = "Vejgade 2",
                      Phone = "23456789",
                      Email = "maistrikker@garn.dk"
                  },
                  new User()
                  {
                      Id = 3,
                      UserName = "NannaHækler123",
                      Name = "Nanna",
                      LastName = "Rister",
                      Password = "maiv",
                      Address = "Vejgade 3",
                      Phone = "34567891",
                      Email = "nannahækler@garn.dk"
                  }
                    );
        }


        public DbSet<User> Users { get; set; }
    }
}
