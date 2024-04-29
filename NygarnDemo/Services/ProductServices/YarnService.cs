using NygarnDemo.Enums;
using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
using System.Drawing;

namespace NygarnDemo.Services.ProductServices
{
    public class YarnService : IYarnService
    {
        public List<Yarn>? YarnProducts { get; set; }

        public YarnService()
        {
            YarnProducts = MockYarn.GetAllYarnProducts();
        }


        public List<Yarn> GetYarnProducts()
        {
            return YarnProducts;
        }

        public IEnumerable<Yarn> NameSearch(string str)
        {
            List<Yarn> nameSearch = new List<Yarn>();
            foreach (Yarn yarn in YarnProducts)
            {
                if (string.IsNullOrEmpty(str) || yarn.Name.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(yarn);
                }
            }

            return nameSearch;
        }

        public IEnumerable<Yarn> PriceFilter(int maxPrice, int minPrice = 0)
        {
            List<Yarn> filterList = new List<Yarn>();
            foreach (Yarn yarn in YarnProducts)
            {
                if ((minPrice == 0 && yarn.Price <= maxPrice) || (maxPrice == 0 && yarn.Price >= minPrice) || (yarn.Price >= minPrice && yarn.Price <= maxPrice))
                {
                    filterList.Add(yarn);
                }
            }

            return filterList;
        }

        public IEnumerable<Yarn> ColorFilter(Enums.Color color)
        {
            List<Yarn> filterColor = new List<Yarn>();
            foreach(Yarn yarn in YarnProducts)
            {
                if (yarn.Color == color)
                {
                    filterColor.Add(yarn);
                }
            }

            return filterColor;
        }

        public IEnumerable<Yarn> MaterialFilter(Material material)
        {
            List<Yarn> MaterialList = new List<Yarn>();
            foreach (Yarn yarn in YarnProducts)
            {
                if (yarn.Material == material)
                {
                    MaterialList.Add(yarn);
                }
            }

            return MaterialList;
        }

        public IEnumerable<Yarn> BrandFilter(Brand brand)
        {
            List<Yarn> BrandList = new List<Yarn>();
            foreach (Yarn yarn in YarnProducts)
            {
                if (yarn.Brand == brand)
                {
                    BrandList.Add(yarn);
                }
            }

            return BrandList;
        }

        public IEnumerable<Yarn> KnittingTensionFilter(KnittigTension knittigTension)
        {
            List<Yarn> KNList = new List<Yarn>();
            foreach (Yarn yarn in YarnProducts)
            {
                if (yarn.KnittingTension == knittigTension)
                {
                    KNList.Add(yarn);
                }
            }

            return KNList;
        }
    }
}
