using NygarnDemo.Models;

namespace NygarnDemo.Services.Interfaces
{
    public interface IKnittingNeedleService
    {
        List<KnittingNeedle> GetKnittingNeedles();
        IEnumerable<KnittingNeedle> NameSearch(string str);
        IEnumerable<KnittingNeedle> PriceFilter(int maxPrice, int minPrice = 0);
        IEnumerable<KnittingNeedle> KnittingNeedleSizeFilter(int maxSize, int minSize = 0); 

        IEnumerable<KnittingNeedle> TypeSearch(string str);

        IEnumerable<KnittingNeedle> MaterialeSearch(string str);
    }
}
