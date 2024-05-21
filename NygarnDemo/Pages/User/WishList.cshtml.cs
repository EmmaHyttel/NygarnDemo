using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.User;
using NygarnDemo.Services.UserService;
using System.Collections.Generic;
using System.Net;
using System.Numerics;

namespace NygarnDemo.Pages.User
{
    public class WishListModel : PageModel
    {
        private readonly IWishListService _wishList;
        [BindProperty]
        public int WishListId { get; set; }
        [BindProperty]
        public int ProduktId { get; set; }
        [BindProperty]

        public CrochetHook CrochetHook { get; set; }
        [BindProperty]

        public KnittingNeedle KnittingNeedle { get; set; }
        [BindProperty]

        public Pattern Pattern { get; set; }
        [BindProperty]

        public Yarn Yarn { get; set; }
        [BindProperty]

        public Tool Tool { get; set; }
        [BindProperty]
        public Models.User User { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        //public async Task<IActionResult> OnPost()
        //{
        
        //}

    }
}
