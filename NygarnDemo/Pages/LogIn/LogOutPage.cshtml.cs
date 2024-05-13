using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NygarnDemo.Pages.LogInPage
{
    public class LogOutPageModel : PageModel
    {
          public async Task<IActionResult> OnGet()
          {
            //Context. = null;

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                return RedirectToPage("/index");
          }
    }
}
