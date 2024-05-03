using Microsoft.EntityFrameworkCore;
using NygarnDemo.Models;

namespace NygarnDemo.EFDbContext;

public class YarnDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=mssql11.unoeuro.com;Initial Catalog=nygarndemo_dk_db_the_database; Integrated Security=True; Connect Timeout=30; Encrypt=False");
        }

    public DbSet<Yarn> YarnProducts { get; set; }
    public DbSet<User> Users { get; set; }
}
