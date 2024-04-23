using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.MockData;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Services.ProductServices;
using System.Security.Cryptography.X509Certificates;

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
