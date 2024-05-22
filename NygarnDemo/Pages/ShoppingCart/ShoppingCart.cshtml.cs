using Microsoft.AspNetCore.Mvc.RazorPages;
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
    public IList<Models.Product> Products { get; private set; } = new List<Models.Product>();
 
    public async Task OnGet()
    {
        var username = HttpContext.User.FindFirstValue(ClaimTypes.Name);
        var shoppingCartLines = await _userService.GetShoppingCartByUserName(username);

        // TODO: Implementer product service til at hente produkter og vise dem her.

        Debug.WriteLine(shoppingCartLines.Count);

    }
}
