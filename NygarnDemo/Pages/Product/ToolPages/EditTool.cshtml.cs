using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
        public Models.Tool? Tools { get; set; }


        public IActionResult OnGet(int id)
        {
            Tools = _toolService.GetTool(id);
            if (Tools == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Tools != null) 
            { 
                await _toolService.UpdateToolAsync(Tools); 
            }

            return RedirectToPage("GetAllTools");
        }

    }
}
