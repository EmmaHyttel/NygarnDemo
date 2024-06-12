using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.User;
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
    public decimal Subtotal { get; set; }
    public decimal DeliveryFee { get; set; }
    public decimal Total { get; set; }

    public async Task OnGet()
    {
        var username = HttpContext.User.FindFirstValue(ClaimTypes.Name);
        ShoppingCartLines = await _userService.GetShoppingCartByUserName(username);

        CalculateOrderSummary();
    }
    public async Task<IActionResult> OnPostUpdateQuantity(int productId, int quantity)
    {
        if(quantity  > 0)
        {
            var user = HttpContext.User.FindFirstValue(ClaimTypes.Name);

            if (user is not null)
            {
                await _userService.UpdateShoppingCart(user, productId, quantity);
            }

            return RedirectToPage("ShoppingCart");
        }

        return Page();
    }

    private void CalculateOrderSummary()
    {
        if (ShoppingCartLines != null && ShoppingCartLines.Any())
        {
            Subtotal = ShoppingCartLines.Sum(line => line.CalculateLineTotal());

            if (Subtotal < 250)
            {
                DeliveryFee = 29;

                Total = Subtotal + DeliveryFee;
            }
            else
            {
                DeliveryFee = 0;
                Total = Subtotal + DeliveryFee;
            }
        }
        else
        {
            Subtotal = 0;
            DeliveryFee = 0;
            Total = 0;
        }
    }


}
