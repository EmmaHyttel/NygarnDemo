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
        public Models.Tool Tools { get; set; }


        public IActionResult OnGet(int id)
        {
            Tools = _toolService.GetTool(id);
            if (Tools == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    Models.Tool deletedTool = await _toolService.DeleteToolAsync(id);
        //    if (deletedTool == null)
        //        return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

        //    return RedirectToPage("GetAllTools");
        //}
    }
}
