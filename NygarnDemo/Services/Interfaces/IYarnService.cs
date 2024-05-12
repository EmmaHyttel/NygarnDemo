using NygarnDemo.Enums;
using NygarnDemo.Models;
using System.Drawing;
using Size = NygarnDemo.Enums.Size;

namespace NygarnDemo.Services.Interfaces
{
    public interface IYarnService
    {
        List<Yarn> GetYarnProducts();

        Task AddYarnAsync(Yarn yarn);

        IEnumerable<Yarn> NameSearch(string str);

        IEnumerable<Yarn> PriceFilter(int maxPrice, int minPrice = 0);

        IEnumerable<Yarn> ColorFilter(Enums.Color color);

        IEnumerable<Yarn> MaterialFilter(Material material);
        IEnumerable<Yarn> BrandFilter(string brand);
        IEnumerable<Yarn> KnittingTensionFilter(string knittigTension);
        IEnumerable<Yarn> YardageFilter(string yardage);
        IEnumerable<Yarn> SizeFilter(Size size);
        //IEnumerable<Yarn> MachinewashFilter(Machinewash machinewash);

    }
}
