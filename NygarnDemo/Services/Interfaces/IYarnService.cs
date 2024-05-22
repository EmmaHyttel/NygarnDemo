using NygarnDemo.Enums;
using NygarnDemo.Models;
using System.Drawing;
using Size = NygarnDemo.Enums.Size;

namespace NygarnDemo.Services.Interfaces
{
    public interface IYarnService
    {
        Task<List<Yarn>> GetYarnProducts();

        Task AddYarnAsync(Yarn yarn);
        Task<Yarn?> DeleteYarnAsync(int? id);
        Task<Yarn?> GetYarn(int id);
        Task<List<Yarn>> NameSearch(string str);
        Task<List<Yarn>> PriceFilter(int maxPrice, int minPrice = 0);
        Task<List<Yarn>> ColorFilter(Enums.Color color);
        Task<List<Yarn>> MaterialFilter(Material material);
        Task<List<Yarn>>BrandFilter(string brand);
        Task<List<Yarn>> KnittingTensionFilter(string knittigTension);
        Task<List<Yarn>> YardageFilter(string yardage);
        Task<List<Yarn>> SizeFilter(Size size);
        //IEnumerable<Yarn> MachinewashFilter(Machinewash machinewash);

    }
}
