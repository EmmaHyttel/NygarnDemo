using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.PatternPages
{
    public class GetAllPatternsModel : PageModel
    {
        private IPatternService _patternService;

        public GetAllPatternsModel(IPatternService patternService)
        {
            _patternService = patternService;
        }
        public List<Models.Pattern>? Patterns { get; private set; }

        public void OnGet()
        {
            Patterns = _patternService.GetPatterns();
        }
    }
}
