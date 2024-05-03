using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services
{
    public class DbService
    {
        public async Task<List<Yarn>> GetYarnProducts()
        {
            using (var context = new YarnDbContext())
            {
                return await context.YarnProducts.ToListAsync();
            }
        }

        public async Task AddYarn(Yarn yarn)
        {
            using (var context = new YarnDbContext())
            {
                context.YarnProducts.Add(yarn);
                context.SaveChanges();
            }
        }

        public async Task SaveYarnProducts(List<Yarn> yarnProducts)
        {
            using (var context = new YarnDbContext())
            {
                foreach (Yarn yarn in yarnProducts)
                {
                    context.YarnProducts.Add(yarn);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }
    }
}
