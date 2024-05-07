using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Services.ProductServices;

namespace NygarnDemo.Pages.Product.YarnPages
{
	public class CreateYarnModel : PageModel
	{
		private IYarnService _yarnService;
        

        [BindProperty]
		public Yarn Yarn { get; set; }

		public CreateYarnModel(IYarnService yarnService)
		{
			_yarnService = yarnService;
			
		}

		public IActionResult OnGet()
		{
			return Page();
		}
		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			_yarnService.AddYarn(Yarn);
			return RedirectToPage("GetAllYarnProducts");
		}
	}
}
