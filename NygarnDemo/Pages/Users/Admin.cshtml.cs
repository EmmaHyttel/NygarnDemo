using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Services.User;
using System.ComponentModel.DataAnnotations;


namespace NygarnDemo.Pages.User
{
    [Authorize(Roles = "admin")]
    public class AdminModel : PageModel
    {
      
        [BindProperty]
        public string UserName { get; set; }

        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }

        private PasswordHasher<string> passwordHasher;

        private UserService _userService;

        public AdminModel(string userName, string password, PasswordHasher<string> passwordHasher, UserService userService)
        {
            UserName = userName;
            Password = password;
            this.passwordHasher = passwordHasher;
            _userService = userService;
        }

        public void OnGet()
        {
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }
        //    await _userService.AddUser(new User(UserName, passwordHasher.HashPassword(null, Password)));
        //    return RedirectToPage("/index");
        //}
    }
}
