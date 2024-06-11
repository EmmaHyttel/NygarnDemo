using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.User;
using System.Security.Claims;

namespace NygarnDemo.Pages.ShoppingCart
{
	public class DeleteShoppingCartLineModel : PageModel
    {
        private IUserService _userService;

        public DeleteShoppingCartLineModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public ShoppingCartLine ShoppingCartLine { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            var userName = HttpContext.User.FindFirstValue(ClaimTypes.Name);
			ShoppingCartLine = await _userService.GetShoppingCartLineByUserName(userName, id);

			if (ShoppingCartLine is null)
            {
                return RedirectToPage("/Construction/NotFound");
            }
            return Page();
		}

        public async Task<IActionResult> OnPostAsync(int id)
        {
			try
			{
				var userName = HttpContext.User.FindFirstValue(ClaimTypes.Name);
				ShoppingCartLine = await _userService.GetShoppingCartLineByUserName(userName, id);

				if (userName is not null)
				{
					await _userService.DeleteShoppingCartLine(id, userName);
				}

				return RedirectToPage("/ShoppingCartPages/ShoppingCart");
			}
			catch (InvalidOperationException)
			{
				ModelState.AddModelError(string.Empty, "Der opstod en fejl ved sletning!");
				return Page();
			}
        }
    }
}
