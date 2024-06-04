using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Services.User;
using System.Security.Claims;

namespace NygarnDemo.Pages.Product.YarnPages
{
   
    public class DetailYarnModel : PageModel
    {

        private IYarnService _yarnService;
        private IUserService _userService;

        public DetailYarnModel(IYarnService yarnService)
        {
            _yarnService = yarnService;
        }

        [BindProperty]
        public Models.Yarn YarnProduct { get; set; }

        [BindProperty]
        public int SelectedProductId { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            YarnProduct = await _yarnService.GetYarn(id);
            if (YarnProduct == null)
                return RedirectToPage("/NotFound"); 

            return Page();
        }
        public async Task<IActionResult> OnPostAddToCart(int quantity)
        {
            var user = HttpContext.User.FindFirstValue(ClaimTypes.Name);

            if (user is not null)
            {
                var product = await _yarnService.GetYarn(SelectedProductId);
                await _userService.AddToShoppingCart(user, product, quantity);
            }

            return RedirectToPage();
        }

    }
}
