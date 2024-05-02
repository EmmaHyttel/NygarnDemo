using Microsoft.EntityFrameworkCore;
using NygarnDemo.Models;

namespace NygarnDemo.EFDbContext;

public class YarnDbContext
{
    public class ItemDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ItemDB; Integrated Security=True; Connect Timeout=30; Encrypt=False");
        }

        public DbSet<Yarn> YarnProducts { get; set; }
        //public DbSet<User> Users { get; set; }
    }
}
