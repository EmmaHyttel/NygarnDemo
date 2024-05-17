using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using System.Collections.Generic;

namespace NygarnDemo.Pages.User
{
    public class WishListModel : PageModel
    {
        [BindProperty]
        public List<WishListModel> WishList { get; set; }

        [BindProperty]
        public Models.User User { get; set; }

        public WishListModel(Models.User user)
        {
            User = user;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        //public IActionResult OnPost()
        //{
           
        //}
    }
}
