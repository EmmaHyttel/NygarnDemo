using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.ToolPages
{
    [Authorize(Roles = "admin")]
    public class EditToolModel : PageModel
    {
        private IToolService _toolService;
        private IWebHostEnvironment _webHostEnvironment;

        public EditToolModel(IToolService toolService, IWebHostEnvironment webHost)
        {
            _toolService = toolService;
            this._webHostEnvironment = webHost;
        }

        [BindProperty]
        public Tool? Tool { get; set; }


        //public IActionResult OnGet(int id)
        //{
        //    Tool = _toolService.GetTool(id);
        //    if (Tool == null)
        //        return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

        //    return Page();
        //}
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Tool = await _toolService.GetTool(id);
            if (Tool == null)
                return RedirectToPage("/NotFound"); // Husk at definere NotFound-siden senere

            return Page();
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if(Tool != null)
            {
                await _toolService.UpdateToolAsync(Tool);
            }   

            return RedirectToPage("/Product/ToolPages/GetAllTools");
        }

    }
}
