using NygarnDemo.Enums;
using NygarnDemo.Models;
using NygarnDemo.Services.DbServices;
using NygarnDemo.Services.Interfaces;
using Size = NygarnDemo.Enums.Size;

namespace NygarnDemo.Services.ProductServices;

public class YarnService : IYarnService
    {
        private readonly YarnDbService _dbService;

	    public List<Yarn> YarnProducts { get; set; }

	    public YarnService(YarnDbService dbService)
        {
            _dbService = dbService;
            YarnProducts = _dbService.GetYarnProducts().Result.ToList();
        }

	    public async Task<List<Yarn>> GetYarnProducts()
        {
            return await _dbService.GetYarnProducts();
        }

        
        /// <summary>
        /// Tilføjer et nyt garnprodukt til databasen asynkront
        /// </summary>
        /// <param name="yarn">Garnobjektet, der skal tilføjes til databasen</param>
        
	    public async Task AddYarnAsync(Yarn yarn)
	    {
            //Kalder dbservice til at tilføje garnet til databasen
            await _dbService.AddYarn(yarn);
	    }

        public async Task<List<Yarn>> NameSearch(string str)
        {
            List<Yarn> nameSearch = new List<Yarn>();
            var yarnProducts = await GetYarnProducts();
            foreach (Yarn yarn in yarnProducts)
            {
                if (string.IsNullOrEmpty(str) || yarn.Name.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(yarn);
                }
            }

            return nameSearch;
        }

        public async Task<List<Yarn>> PriceFilter(int maxPrice, int minPrice = 0)
        {
            List<Yarn> filterList = new List<Yarn>();
            var yarnProducts = await GetYarnProducts();

            foreach (Yarn yarn in yarnProducts)
            {
                if ((minPrice == 0 && yarn.Price <= maxPrice) || (maxPrice == 0 && yarn.Price >= minPrice) || (yarn.Price >= minPrice && yarn.Price <= maxPrice))
                {
                    filterList.Add(yarn);
                }
            }

            return filterList;
        }

        public async Task<List<Yarn>> ColorFilter(Color color)
        {
            List<Yarn> filterColor = new List<Yarn>();
            var yarnProducts = await GetYarnProducts();

            foreach (Yarn yarn in yarnProducts)
            {
                if (yarn.Color == color)
                {
                    filterColor.Add(yarn);
                }
            }

            return filterColor;
        }

        public async Task<List<Yarn>> MaterialFilter(Material material)
        {
            List<Yarn> MaterialList = new List<Yarn>();
            var yarnProducts = await GetYarnProducts();

            foreach (Yarn yarn in yarnProducts)
            {
                if (yarn.Material == material)
                {
                    MaterialList.Add(yarn);
                }
            }

            return MaterialList;
        }

    /// <summary>
    /// Sletter garnproduktet asynkront med det angivede produktId fra databasen
    /// </summary>
    /// <param name="productId">ProduktId'et for det garnprodukt, der skal slettes</param>
    /// <returns>Det slettede garnprodukt, hvis det bliver fundet ellers returneres null</returns>

    public async Task<Yarn?> DeleteYarnAsync(int? productId)
    {
        //initialiserer en lokalvariabel til at holde garnproduktet, der skal slettes
        Yarn YarnToBeDeleted = null;

        //Gennemgår alle garnprodukter for at finde det produkt, med det angivede produktId
        foreach (Yarn yarn in YarnProducts)
        {
            if (yarn.ProductId == productId)
            {
                YarnToBeDeleted = yarn;
                break;
            }
        }

        //Hvis det garnprodukt, der skal slettes findes
        if (YarnToBeDeleted != null)
        {
            //YarnProducts.Remove(YarnToBeDeleted);

            //Sletter garnproduktet fra databasen via DeleteYarn metoden i dbService
            await _dbService.DeleteYarn(YarnToBeDeleted);
        }

        //Returnerer det slettede garnprodukt, hvis det blev fundet, ellers returneres null
        return YarnToBeDeleted;
    }

    public async Task<Yarn?> GetYarn(int id)
    {
        var yarnProducts = await GetYarnProducts();

        foreach (Yarn yarn in yarnProducts)
        {
            if (yarn.ProductId == id)
                return yarn;
        }

        return null;
    }

	public async Task UpdateYarnAsync(Yarn yarn)
	{
		if (yarn != null)
		{
			foreach (Yarn y in YarnProducts)
			{
				if (y.ProductId == yarn.ProductId)
				{
                    y.Name = yarn.Name;
                    y.Price = yarn.Price;
                    y.Description = yarn.Description;
                }

			}
			await _dbService.UpdateYarn(yarn);
		}
	}
}
