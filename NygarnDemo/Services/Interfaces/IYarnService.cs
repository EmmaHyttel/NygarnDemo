using NygarnDemo.Models;

namespace NygarnDemo.Services.Interfaces
{
    public interface IYarnService
    {
        List<Yarn> GetYarnProducts();

        IEnumerable<Yarn> NameSearch(string str);

        IEnumerable<Yarn> PriceFilter(int maxPrice, int minPrice = 0);


    }
}
