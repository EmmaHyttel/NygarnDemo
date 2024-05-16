using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services.DbServices;

public class YarnDbService
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
            await context.YarnProducts.AddAsync(yarn);
            await context.SaveChangesAsync();
        }
    }

    public async Task SaveYarnProducts(List<Yarn> yarnProducts)
    {
        using (var context = new YarnDbContext())
        {
            foreach (Yarn yarn in yarnProducts)
            {
                await context.YarnProducts.AddAsync(yarn);
            }

            await context.SaveChangesAsync();
        }
    }
}
