using NygarnDemo.Models;

namespace NygarnDemo.Services.Interfaces
{
    public interface ICrochetHookService
    {
        List<CrochetHook> GetCrochetHooks();
        IEnumerable<CrochetHook> CrochetHooksPriceFilter (int maxPrice, int minPrice = 0);
        IEnumerable<CrochetHook> NameSearch(string str);

        IEnumerable<CrochetHook> CrochetHooksSizeFilter(int maxSize, int minSize = 0);
    }
}
