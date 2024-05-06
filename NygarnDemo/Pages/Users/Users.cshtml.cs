using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.User;
using System.ComponentModel.DataAnnotations;

namespace NygarnDemo.Pages.Users
{
    //[Authorize(Roles = "admin")]
    public class UsersModel : PageModel
    {

        [BindProperty]
        public string UserName { get; set; }

        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }

        private PasswordHasher<string> passwordHasher;

        private UserService _userService;

        public UsersModel()
        {
        }

        public UsersModel(UserService userService)
        {
           _userService = userService;
            passwordHasher = new PasswordHasher<string>();
        }


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _userService.AddUser(new User(UserName, passwordHasher.HashPassword(null, Password)));
            return RedirectToPage("/index");
        }
    }
}
