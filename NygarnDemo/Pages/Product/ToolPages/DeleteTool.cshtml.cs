using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.ToolPages
{
    
    public class DeleteToolModel : PageModel
    {

        private IToolService _toolService;

        public DeleteToolModel(IToolService ToolService)
        {
            _toolService = ToolService;
        }

        [BindProperty]
        public Models.Tool Tool { get; set; }


        public IActionResult OnGet(int id)
        {
            Tool = _toolService.GetTool(id);
            if (Tool == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Models.Tool deletedTool = await _toolService.DeleteToolAsync(Tool.Id);
            if (deletedTool == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return RedirectToPage("GetAllTools");
        }
    }
}
