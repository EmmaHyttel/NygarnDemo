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
    

        public IActionResult OnGet(int id)
        {
            Yarn = _yarnService.GetYarn(id);
            if (Yarn == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Models.Yarn deletedYarn = await _yarnService.DeleteYarnAsync(Yarn.ProductId);
            if (deletedYarn == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return RedirectToPage("GetAllYarnProducts");
        }
    }
}