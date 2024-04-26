using NygarnDemo.Models;

namespace NygarnDemo.Services.Interfaces
{
    public interface IKnittingNeedleService
    {
        List<KnittingNeedle> GetKnittingNeedles();

        IEnumerable<KnittingNeedle> KnittingFilterList(int maxSize, int minSize = 0);
    }
}
