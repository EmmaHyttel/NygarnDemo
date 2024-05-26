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


        public async Task<IActionResult> OnGetAsync(int id)
        {
            YarnProduct = await _yarnService.GetYarn(id);
            if (YarnProduct == null)
                return RedirectToPage("/NotFound"); // Husk at definere NotFound-siden senere

            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            if (YarnProduct != null)
            {
                await _yarnService.UpdateYarnAsync(YarnProduct);
            }

            return RedirectToPage("/Product/YarnPages/GetAllYarnProducts");
        }
    }
}
