using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Enums;
using NygarnDemo.Services.ProductServices;

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

        [BindProperty]
        public string SearchString { get; set; }

        [BindProperty]
        public string Designer { get; set; }

        [BindProperty]
        public string DifficultyLevel { get; set; }

        [BindProperty]
        public Fits Fits { get; set; }

        [BindProperty]
        public Category Category { get; set; }

        [BindProperty]
        public bool FreePattern { get; set; }   

        public void OnGet()
        {
            Patterns = _patternService.GetPatterns();
        }

        public IActionResult OnPostCategoryFilter()
        {
            Patterns = _patternService.CategoryFilter(Category).ToList();
            return Page();
        }
    }
}
