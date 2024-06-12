using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.YarnPages
{
	[Authorize(Roles = "admin")]
	public class EditYarnModel : PageModel
    {
        private IYarnService _yarnService;
        private IWebHostEnvironment _webHostEnvironment;

        public EditYarnModel(IYarnService yarnService, IWebHostEnvironment webHost)
        {
            _yarnService = yarnService;
            this._webHostEnvironment = webHost;
        }

        [BindProperty]
        public Yarn? YarnProduct { get; set; }

		[BindProperty]
		public IFormFile? Photo { get; set; }

		public async Task<IActionResult> OnGetAsync(int id)
        {
            YarnProduct = await _yarnService.GetYarn(id);
            if (YarnProduct == null)
                return RedirectToPage("/NotFound"); 

            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
			if (Photo != null && YarnProduct != null)
			{
				if (YarnProduct.ProductImage != null)
				{
					string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "/pngFiles", YarnProduct.ProductImage);
					System.IO.File.Delete(filePath);
				}

				YarnProduct.ProductImage = ProcessUploadedFile();
			}
			if (YarnProduct != null)
            {
                await _yarnService.UpdateYarnAsync(YarnProduct);
            }

            return RedirectToPage("/Product/YarnPages/GetAllYarnProducts");
        }



		private string ProcessUploadedFile()
		{
			string uniqueFileName = null;
			if (Photo != null)
			{
				string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "pngFiles");
				uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
				string filePath = Path.Combine(uploadsFolder, uniqueFileName);
				using (var fileStream = new FileStream(filePath, FileMode.Create))
				{
					Photo.CopyTo(fileStream);
				}
			}
			return uniqueFileName;
		}
	}
}
