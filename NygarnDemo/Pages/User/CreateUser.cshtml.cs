using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NygarnDemo.Models;
using NygarnDemo.Services.User;
using System.ComponentModel.DataAnnotations;

namespace NygarnDemo.Pages.Users;

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

    private PasswordHasher<string> passwordHasher;

    //public CreateUserModel()
    //{
    //}

    public CreateUserModel(IUserService userService)
    {
       _userService = userService;
        passwordHasher = new PasswordHasher<string>();
    }

    

    public IActionResult OnGet()
    {
        return Page();
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        try
        {
            var hashedPassword = passwordHasher.HashPassword(UserName, Password);

            var newUser = new Models.User(UserName, Name, LastName, hashedPassword, Address, Phone, Email);

            await _userService.AddUserAsync(newUser);

            return RedirectToPage("/LogIn/LogInPage");
        }

        catch (Exception ex)
        {
            ModelState.AddModelError("UserName", ex.Message); 
            return Page();
        }

        //await _userService.AddUserAsync(new Models.User(UserName, Name, LastName, passwordHasher.HashPassword(UserName, Password), Address, Phone, Email));
    }
}
