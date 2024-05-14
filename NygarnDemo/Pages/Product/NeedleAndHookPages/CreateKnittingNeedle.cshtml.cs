using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.NeedleAndHookPages
{
	public class CreateKnittingNeedleModel : PageModel
	{
		private IKnittingNeedleService _knittingNeedleService;
		private IWebHostEnvironment _webHostEnvironment;


		[BindProperty]
		public KnittingNeedle knittingNeedle { get; set; }

		public CreateKnittingNeedleModel(IKnittingNeedleService knittingNeedleService, IWebHostEnvironment webHost)
		{
			_knittingNeedleService = knittingNeedleService;
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
			await _knittingNeedleService.AddKnittingNeedleAsync(knittingNeedle);
			return RedirectToPage("GetAllNeedlesAndHooks");
		}
	}
}

