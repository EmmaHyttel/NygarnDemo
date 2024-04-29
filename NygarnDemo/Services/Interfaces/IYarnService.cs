using NygarnDemo.Enums;
using NygarnDemo.Models;
using System.Drawing;

namespace NygarnDemo.Services.Interfaces
{
    public interface IYarnService
    {
        List<Yarn> GetYarnProducts();

        IEnumerable<Yarn> NameSearch(string str);

        IEnumerable<Yarn> PriceFilter(int maxPrice, int minPrice = 0);

        IEnumerable<Yarn> ColorFilter(Enums.Color color);

        IEnumerable<Yarn> MaterialFilter(Material material);
        IEnumerable<Yarn> BrandFilter(Brand brand);
        IEnumerable<Yarn> KnittingTensionFilter(KnittigTension knittigTension);
        IEnumerable<Yarn> YardageFilter(Yardage yardage
            );

    }
}
