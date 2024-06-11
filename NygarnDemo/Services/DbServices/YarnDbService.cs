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

    /// <summary>
    /// Asynkront tilføjer et nyt garnprodukt til databasen
    /// </summary>
    /// <param name="yarn">Det garnprodukt, der skal tilføjes til databasen</param>
    /// <returns>Task, der repræsenterer den asynkrone tilføjelsesoperation</returns>
    public async Task AddYarn(Yarn yarn)
    {
        //Opretter en ny instans af databasekonteksten
        using (var context = new NygarnDbContext())
        {
            //Tilføjer det angivne garnprodukt til konteksten
            await context.Yarn.AddAsync(yarn);

            //Gemmer ændringerne i databasen
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

    /// <summary>
    /// Asynkront sletter et garnprodukt fra databasen
    /// </summary>
    /// <param name="yarn">Garnproduktet der skal slettes</param>
    /// <returns>Task, der repræsenterer den asynkrone sletningsopereation</returns>
    public async Task DeleteYarn(Yarn yarn)
    {
        //Opretter en instanse af databasekonteksten
        using (var context = new NygarnDbContext())
        {
            //Fjerner det angivne garnprodukt fra konteksten
            context.Yarn.Remove(yarn);

            //Gemmer ændringerne i databasen
            await context.SaveChangesAsync();
        }
    }

}
