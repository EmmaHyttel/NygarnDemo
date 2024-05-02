using NygarnDemo.Enums;
using NygarnDemo.Models;
using NygarnDemo.Services.ProductServices;

namespace NygarnDemo.Services.Interfaces
{
    public interface IToolService
    {
        List<Tool> GetToolsProducts();
        IEnumerable<Tool> PriceFilter(int maxPrice, int minPrice = 0);

        IEnumerable<Tool> SizeFilter(string str);

        IEnumerable<Tool> BrandFilter(Brand brand);

        IEnumerable<Tool>  NameSearch(string str);

        IEnumerable<Tool> TypeFilter(ToolType type);
    }
}
