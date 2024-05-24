using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.ToolPages
{
    [Authorize(Roles = "admin")]
    public class DeleteToolModel : PageModel
    {
        private IToolService _toolService;

        public DeleteToolModel(IToolService ToolService)
        {
            _toolService = ToolService;
        }

        [BindProperty]
        public Tool Tool { get; set; }

        //[BindProperty]
        //public int DeletedToolId { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Tool = await _toolService.GetTool(id);
            if (Tool == null)
                return RedirectToPage("/Construction/NotFound"); 

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Tool deletedTool = await _toolService.DeleteToolAsync(Tool.ProductId);
            if (deletedTool == null)
                return RedirectToPage("/Construction/NotFound");

            return RedirectToPage("/Product/ToolPages/GetAllTools");
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    var tool = await _toolService.GetTool(DeletedToolId);
        //    await _toolService.DeleteTool(tool);
        //    if (DeletedToolId == null)
        //        return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

        //    return RedirectToPage("GetAllTools");
        //}


        //public async Task<IActionResult> OnPostDeleteTool()
        //{
        //    // Check if DeletedToolId is valid
        //    //if (DeletedToolId == 0)
        //    //{
        //    //    return RedirectToPage("/Index");
        //    //}

        //    // Fetch the tool to be deleted
        //    var tool = await _toolService.GetTool(DeletedToolId);
        //    if (tool == null)
        //    {
        //        return RedirectToPage("/Index");
        //    }

        //    // Delete the tool
        //    await _toolService.DeleteTool(tool);

        //    // Redirect to GetAllTools page
        //    return RedirectToPage("GetAllTools");
        //}
    }

    
}
