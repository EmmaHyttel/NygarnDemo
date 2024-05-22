using NygarnDemo.Enums;
using NygarnDemo.Models;
using NygarnDemo.Services.DbServices;
using NygarnDemo.Services.Interfaces;
using Size = NygarnDemo.Enums.Size;

namespace NygarnDemo.Services.ProductServices;

public class YarnService : IYarnService
    {
        private readonly YarnDbService _dbService;

        public YarnService(YarnDbService dbService)
        {
            _dbService = dbService;
        }

	    public async Task<List<Yarn>> GetYarnProducts()
        {
            return await _dbService.GetYarnProducts();
        }

	    public async Task AddYarnAsync(Yarn yarn)
	    {
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

        public async Task<List<Yarn>> ColorFilter(Enums.Color color)
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

    public async Task<List<Yarn>> BrandFilter(string str)
    {
        List<Yarn> brandFilter = new List<Yarn>();
        var yarnProducts = await GetYarnProducts();

        foreach (Yarn yarn in yarnProducts)
        {
            if (string.IsNullOrEmpty(str) || yarn.Name.ToLower().Contains(str.ToLower()))
            {
                brandFilter.Add(yarn);
            }
        }
        return brandFilter;
    }

    public async Task<List<Yarn>> KnittingTensionFilter(string knittingTension)
    {
        List<Yarn> KNTension = new List<Yarn>();
        var yarnProducts = await GetYarnProducts();

        foreach (Yarn yarn in yarnProducts)
        {
            if (string.IsNullOrEmpty(knittingTension) || yarn.Name.ToLower().Contains(knittingTension.ToLower()))
            {
                KNTension.Add(yarn);
            }
        }
        return KNTension;
    }

     public async Task<List<Yarn>> YardageFilter(string yardage)
     {
            List<Yarn> YardageList = new List<Yarn>();
            var yarnProducts = await GetYarnProducts();

            foreach (Yarn yarn in yarnProducts)
            {
                if (yarn.Yardage == yardage)
                {
                    YardageList.Add(yarn);
                }
            }

            return YardageList;
     }

     public async Task<List<Yarn>> SizeFilter(Size size)
     {
         List<Yarn> SizeList = new List<Yarn>();

         var yarnProducts = await GetYarnProducts();

         foreach (Yarn yarn in yarnProducts)
         {
             if (yarn.SuggestedNeedleSize == size)
             {
                    SizeList.Add(yarn);
             }
         }

            return SizeList;
     }

    public async Task<Yarn?> DeleteYarnAsync(int? id)
    {
        Yarn YarnToBeDeleted = null;

        var yarnProducts = await GetYarnProducts();

        foreach (Yarn yarn in yarnProducts)
        {
            if (yarn.ProductId == id)
            {
                YarnToBeDeleted = yarn;
                break;
            }
        }
        if (YarnToBeDeleted != null)
        {
            yarnProducts.Remove(YarnToBeDeleted);
            //await _dbService.DeleteToolsAsync(ToolToBeDeleted);
        }

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


    //public IEnumerable<Yarn> MachinewashFilter()
    //{
    //    List<Yarn> MachinewashList = new List<Yarn>();
    //    foreach (Yarn yarn in YarnProducts)
    //    {
    //        if (yarn.MachineWash == )
    //        {
    //            MachinewashList.Add(yarn);
    //        }
    //    }

    //    return MachinewashList;
    //}
}
