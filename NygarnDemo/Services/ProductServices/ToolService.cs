using NygarnDemo.Enums;
using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Services.ProductServices
{
    public class ToolService : IToolService
    {
        public List<Tool> ToolProducts { get; set; }

        public ToolService()
        {
            ToolProducts = MockTool.GetAllToolProducts();
        }

        public List<Tool> GetToolsProducts()
        {
            return ToolProducts;
        }

        public IEnumerable<Tool> PriceFilter(int maxPrice, int minPrice = 0)
        {
            List<Tool> filterList = new List<Tool>();
            foreach (Tool priceFilter in ToolProducts)
            {
                if ((minPrice == 0 && priceFilter.Price <= maxPrice) || (maxPrice == 0 && priceFilter.Price >= minPrice) || (priceFilter.Price >= minPrice && priceFilter.Price <= maxPrice))
                {
                    filterList.Add(priceFilter);
                }
            }
            return filterList;
        }
        public IEnumerable<Tool> SizeFilter(string str)
        {
            List<Tool> sizeFilter = new List<Tool>();
            foreach (Tool tool in ToolProducts)
            {
                if (string.IsNullOrEmpty(str) || tool.Name.ToLower().Contains(str.ToLower()))
                {
                    sizeFilter.Add(tool);
                }
            }
            return sizeFilter;
        }

        public IEnumerable<Tool> BrandFilter(Brand brand)
        {
            List<Tool> brandList = new List<Tool>();
            foreach (Tool tool in ToolProducts)
            {
                if (tool.Brand == brand)
                {
                    brandList.Add(tool);
                }
            }

            return brandList;
        }

        public IEnumerable<Tool> NameSearch(string str)
        {
            List<Tool> nameSearch = new List<Tool>();
            foreach (Tool tool in ToolProducts)
            {
                if (string.IsNullOrEmpty(str) || tool.Name.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(tool);
                }
            }
            return nameSearch;
        }
        public IEnumerable<Tool> TypeFilter(ToolType type)
        {
            List<Tool> brandList = new List<Tool>();
            foreach (Tool t in ToolProducts)
            {
                if (t.Type == type)
                {
                    brandList.Add(t);
                }
            }
            return brandList;
        }
    }
}
