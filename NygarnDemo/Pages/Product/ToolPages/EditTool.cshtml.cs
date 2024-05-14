using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.ToolPages
{
    public class EditToolModel : PageModel
    {
        private IToolService _toolService;
        private IWebHostEnvironment _webHostEnvironment;

        public EditToolModel(IToolService toolService, IWebHostEnvironment webHost)
        {
            _toolService = toolService;
            _webHostEnvironment = webHost;
        }

        [BindProperty]
        public Tool Tool { get; set; }


        public IActionResult OnGet(int id)
        {
            Tool = _toolService.GetTool(id);
            if (Tool == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _toolService.UpdateTool(Tool);
            return RedirectToPage("GetAllTools");
        }

    }
}
