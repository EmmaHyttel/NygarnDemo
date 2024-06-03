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

		//[BindProperty]
		//public IFormFile Photo { get; set; }

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
			//if (Photo != null)
			//{
			//	if (Yarn.ProductImage != null)
			//	{
			//		string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "/pngFiles", Yarn.ProductImage);
			//		System.IO.File.Delete(filePath);
			//	}

			//	Yarn.ProductImage = ProcessUploadedFile();
			//}
			await _yarnService.AddYarnAsync(Yarn);
			return RedirectToPage("GetAllYarnProducts");
		}

		//private string ProcessUploadedFile()
		//{
		//	string uniqueFileName = null;
		//	if (Photo != null)
		//	{
		//		string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "/pngFiles");
		//		uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
		//		string filePath = Path.Combine(uploadsFolder, uniqueFileName);
		//		using (var fileStream = new FileStream(filePath, FileMode.Create))
		//		{
		//			Photo.CopyTo(fileStream);
		//		}
		//	}
		//	return uniqueFileName;
		//}

	}
}
