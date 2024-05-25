using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.User;
using System.Security.Claims;

namespace NygarnDemo.Pages.WishList
{
    public class WishListModel : PageModel
    {
        private IUserService _userService;

        public WishListModel(IUserService userService)
        {
            _userService = userService;
        }
        public List<WishListLine>? WishList { get; private set; }

        public async Task OnGet()
        {
            var username = HttpContext.User.FindFirstValue(ClaimTypes.Name);
            WishList = await _userService.GetWishListByUserName(username);
        }
    }
}
