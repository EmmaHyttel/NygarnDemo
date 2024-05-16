using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.NeedleAndHookPages
{
    [Authorize(Roles = "admin")]
    public class CreateCrochetHookModel : PageModel
    {
		private ICrochetHookService _crochetHookService;
		private IWebHostEnvironment _webHostEnvironment;


		[BindProperty]
		public CrochetHook crochetHook { get; set; }

		public CreateCrochetHookModel(ICrochetHookService crochetHookService, IWebHostEnvironment webHost)
		{
			_crochetHookService = crochetHookService;
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
			await _crochetHookService.AddCrochetHookAsync(crochetHook);
			return RedirectToPage("GetCrochetHooks");
		}
	}
}
