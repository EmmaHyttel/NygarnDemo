using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NygarnDemo.Pages.LogInPage
{
    public class LogOutModel : PageModel
    {
          public async Task<IActionResult> OnGet()
          {
            LogInPageModel.LoggedInUser = null;

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                return RedirectToPage("/index");
          }
    }
}
