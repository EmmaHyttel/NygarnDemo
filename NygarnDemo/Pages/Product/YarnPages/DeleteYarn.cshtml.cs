using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.YarnPages
{
    [Authorize(Roles = "admin")]
    public class DeleteYarnModel : PageModel
    {
        private IYarnService _yarnService;

        public DeleteYarnModel(IYarnService YarnService)
        {
            _yarnService = YarnService;
        }

        [BindProperty]
        public Models.Yarn Yarn { get; set; }
    

        public async Task<IActionResult> OnGet(int id)
        {
            Yarn = await _yarnService.GetYarn(id);
            if (Yarn == null)
                return RedirectToPage("/Construction/NotFound");

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            Models.Yarn deletedYarn = await _yarnService.DeleteYarnAsync(id);
            if (deletedYarn == null)
                return RedirectToPage("/Construction/NotFound");

            return RedirectToPage("GetAllYarnProducts");
        }
    }
}
