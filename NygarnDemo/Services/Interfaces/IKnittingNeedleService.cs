using NygarnDemo.Enums;
using NygarnDemo.Models;
using System.Drawing;
using Size = NygarnDemo.Enums.Size;


namespace NygarnDemo.Services.Interfaces
{
    public interface IKnittingNeedleService
    {

        List<KnittingNeedle> GetKnittingNeedles();

        Task AddKnittingNeedleAsync(KnittingNeedle knittingNeedle);

        IEnumerable<KnittingNeedle> PriceFilter(int maxPrice, int minPrice = 0);
      
        IEnumerable<KnittingNeedle> NameSearch(string str);
      
        IEnumerable<KnittingNeedle> NeedleSizeFilter(Size size);

        IEnumerable<KnittingNeedle> MaterialFilter(NeedleAndHookMaterial material);
      
        IEnumerable<KnittingNeedle> NeedleTypeFilter(NeedleType type);
    }
}
