using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.YarnPages
{
    public class DetailYarnModel : PageModel
    {

        private IYarnService _yarnService;

        public DetailYarnModel(IYarnService yarnService)
        {
            _yarnService = yarnService;
        }

        [BindProperty]
        public Models.Yarn YarnProduct { get; set; }


        //public IActionResult OnGet(int id)
        //{
        //    Tool = _toolService.GetTool(id);
        //    if (Tool == null)
        //        return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

        //    return Page();
        //}

        public async Task<IActionResult> OnGetAsync(int id)
        {
            YarnProduct = await _yarnService.GetYarn(id);
            if (YarnProduct == null)
                return RedirectToPage("/NotFound"); // Husk at definere NotFound-siden senere

            return Page();
        }

    }
}
