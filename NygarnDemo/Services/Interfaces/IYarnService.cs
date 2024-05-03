using NygarnDemo.Enums;
using NygarnDemo.Models;
using System.Drawing;
using Size = NygarnDemo.Enums.Size;

namespace NygarnDemo.Services.Interfaces
{
    public interface IYarnService
    {
        List<Yarn> GetYarnProducts();

        void AddYarn(Yarn yarn);

        IEnumerable<Yarn> NameSearch(string str);

        IEnumerable<Yarn> PriceFilter(int maxPrice, int minPrice = 0);

        IEnumerable<Yarn> ColorFilter(Enums.Color color);

        IEnumerable<Yarn> MaterialFilter(Material material);
        IEnumerable<Yarn> BrandFilter(Brand brand);
        IEnumerable<Yarn> KnittingTensionFilter(KnittigTension knittigTension);
        IEnumerable<Yarn> YardageFilter(Yardage yardage);
        IEnumerable<Yarn> SizeFilter(Size size);
        IEnumerable<Yarn> MachinewashFilter(Machinewash machinewash);

    }
}
