using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.ToolPages
{
    public class CreateToolModel : PageModel
    {

        private IToolService _toolService;
        private IWebHostEnvironment _webHostEnvironment;


        [BindProperty]
        public Tool Tool { get; set; }

        public CreateToolModel(IToolService toolService, IWebHostEnvironment webHost)
        {
            _toolService = toolService;
            _webHostEnvironment = webHost;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _toolService.AddToolAsync(Tool);
            return RedirectToPage("GetAllTools");
        }
    }
}
