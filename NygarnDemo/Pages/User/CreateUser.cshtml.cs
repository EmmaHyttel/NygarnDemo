using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.User;
using System.ComponentModel.DataAnnotations;

namespace NygarnDemo.Pages.Users
{
    //[Authorize(Roles = "admin")]
    public class CreateUserModel : PageModel
    {
        private IUserService _userService;

        [BindProperty]
        public string UserName { get; set; }
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string LastName { get; set; }

        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }
        [BindProperty]
        public string Address { get; set; }
        [BindProperty]
        public string Phone { get; set; }
        [BindProperty]
        public string Email { get; set; }

        //private PasswordHasher<string> passwordHasher;

        //public CreateUserModel()
        //{
        //}

        public CreateUserModel(IUserService userService)
        {
           _userService = userService;
            //passwordHasher = new PasswordHasher<string>();
        }


        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _userService.AddUserAsync(new Models.User(UserName, Name, LastName, /*passwordHasher.HashPassword(null,*/Password, Address, Phone, Email));
            return RedirectToPage("/LogIn/LogInPage");
        }

    }
}
