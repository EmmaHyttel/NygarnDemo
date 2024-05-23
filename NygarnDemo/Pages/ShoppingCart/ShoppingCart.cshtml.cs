using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.User;
using System.Diagnostics;
using System.Security.Claims;

namespace NygarnDemo.Pages.ShoppingCart;

public class ShoppingCartModel : PageModel
{
    private IUserService _userService;

    public ShoppingCartModel(IUserService userService)
    {
        _userService = userService;
    }
    public List<ShoppingCartLine>? ShoppingCartLines { get; private set; }
 
    public async Task OnGet()
    {
        var username = HttpContext.User.FindFirstValue(ClaimTypes.Name);
        ShoppingCartLines = await _userService.GetShoppingCartByUserName(username);

        // TODO: Implementer product service til at hente produkter og vise dem her.
    }
}
