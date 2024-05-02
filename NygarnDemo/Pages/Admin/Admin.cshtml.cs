using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Services.ProductServices;
using System.ComponentModel.DataAnnotations;

namespace NygarnDemo.Pages.Admin
{
    public class AdminModel : PageModel
    {
        private List<Models.Admin>? Admins { get; set; }

        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
