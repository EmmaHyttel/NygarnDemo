using Microsoft.EntityFrameworkCore;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;

namespace NygarnDemo.Services.DbServices;

public class YarnDbService
{
    public async Task<List<Yarn>> GetYarnProducts()
    {
        using (var context = new NygarnDbContext())
        {
            return await context.Yarn.ToListAsync();
        }
    }

    public async Task AddYarn(Yarn yarn)
    {
        using (var context = new NygarnDbContext())
        {
            await context.Yarn.AddAsync(yarn);
            await context.SaveChangesAsync();
        }
    }

    public async Task SaveYarnProducts(List<Yarn> yarnProducts)
    {
        using (var context = new NygarnDbContext())
        {
            foreach (Yarn yarn in yarnProducts)
            {
                await context.Yarn.AddAsync(yarn);
            }

            await context.SaveChangesAsync();
        }
    }

	public async Task UpdateYarn(Yarn yarn)
	{
		using (var context = new NygarnDbContext())
		{
			context.Yarn.Update(yarn);
			await context.SaveChangesAsync();
		}
	}

    public async Task DeleteYarn(Yarn yarn)
    {
        using (var context = new NygarnDbContext())
        {
            context.Yarn.Remove(yarn);
            await context.SaveChangesAsync();
        }
    }

}
