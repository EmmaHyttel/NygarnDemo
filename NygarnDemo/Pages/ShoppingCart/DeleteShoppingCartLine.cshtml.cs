using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Services.ProductServices;
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

        //[BindProperty]
        //public int ProductId { get; set; }


        public async Task<IActionResult> OnGet(int productId)
        {
            //ProductId = productId;
            var userName = HttpContext.User.FindFirstValue(ClaimTypes.Name);
            ShoppingCartLine = await _userService.GetShoppingCartLineByUserName(userName, productId);

			if (ShoppingCartLine == null)
            {
                return RedirectToPage("/Construction/NotFound");
            }
            return Page();
		}

        public async Task<IActionResult> OnPostDeleteShoppingCartLine(int productId)
        {
			try
			{
				var userName = HttpContext.User.FindFirstValue(ClaimTypes.Name);

				if (userName is not null)
				{
					await _userService.DeleteShoppingCartLine(productId, userName);
				}

				return Page();
			}
			catch (InvalidOperationException)
			{
				ModelState.AddModelError(string.Empty, "Der opstod en fejl ved sletning!");
				return Page();
			}
        }
    }
}
