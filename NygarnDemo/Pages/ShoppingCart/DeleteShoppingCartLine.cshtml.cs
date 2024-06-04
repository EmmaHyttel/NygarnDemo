using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
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


        public async Task<IActionResult> OnGet(int productId)
        {
            var userName = HttpContext.User.FindFirstValue(ClaimTypes.Name);

            if (userName is not null)
            {
                await _userService.DeleteShoppingCartLine(productId, userName);
            }

            return Page();
        }

        //public async Task<IActionResult> OnPostDeleteShoppingCartLine(int id)
        //{
        //    var user = HttpContext.User.FindFirstValue(ClaimTypes.Name);

        //    if (user is not null)
        //    {
        //        await _userService.DeleteShoppingCartLine(id, user.UserName);
        //    }
        //}
    }
}
