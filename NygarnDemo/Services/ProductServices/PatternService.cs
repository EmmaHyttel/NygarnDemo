using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Services.ProductServices
{
    public class PatternService : IPatternService
    {
        public List<Pattern>? Patterns { get; set; }

       //public PatternService(IPatternService patternService)
       // {
       //     Patterns = MockPattern.GetAllPatterns();
       // }

        public PatternService()
        {
            Patterns = MockPattern.GetAllPatterns();
        }

        public List<Pattern> GetPatterns()
        {
            return Patterns;
        }
    }
}
