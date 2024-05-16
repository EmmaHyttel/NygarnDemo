using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Enums;
using System.Security.Claims;

namespace NygarnDemo.Pages.Product.PatternPages
{
	public class GetAllPatternsModel : PageModel
    {
        private IPatternService _patternService;
        public bool IsAdmin { get; private set; }
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
		public string[] DifficultyDescriptions { get; private set; }

		public void OnGet()
        {
            Patterns = _patternService.GetPatterns();
            IsAdmin = HttpContext.User.HasClaim(c => c.Type == ClaimTypes.Role && c.Value == "admin");
        }

        public IActionResult OnPostCategoryFilter()
        {
            Patterns = _patternService.CategoryFilter(Category).ToList();
            return Page();
        }
		public IActionResult OnPostFitsFilter()
		{
			Patterns = _patternService.FitsFilter(Fits).ToList();
			return Page();
		}

		public IActionResult OnPostDiffLevelFilter()
		{
            Patterns = _patternService.DiffLevelFilter(DifficultyLevel).ToList();
            return Page();
        }
	}
}
