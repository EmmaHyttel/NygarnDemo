using NygarnDemo.Enums;
using NygarnDemo.Models;

namespace NygarnDemo.Services.Interfaces
{
    public interface IPatternService
    {
        List<Pattern> GetPatterns();
        IEnumerable<Pattern> CategoryFilter(Category category);
		IEnumerable<Pattern> FitsFilter(Fits fits);
	}
}
