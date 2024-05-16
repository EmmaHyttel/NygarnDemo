using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Services.ProductServices;

namespace NygarnDemo.Pages.Product.YarnPages
{
	[Authorize(Roles = "admin")]
	public class CreateYarnModel : PageModel
	{
		private IYarnService _yarnService;
		private IWebHostEnvironment _webHostEnvironment;

        [BindProperty]
		public Yarn Yarn { get; set; }

		public CreateYarnModel(IYarnService yarnService, IWebHostEnvironment webHost)
		{
			_yarnService = yarnService;
			_webHostEnvironment = webHost;
        }

        public IActionResult OnGet()
		{
			return Page();
		}
		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			await _yarnService.AddYarnAsync(Yarn);
			return RedirectToPage("GetAllYarnProducts");
		}
	}
}
