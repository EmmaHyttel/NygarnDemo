using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.ToolPages;

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

    public async Task<IActionResult> OnGetAsync(int id)
    {
        Tool = await _toolService.GetTool(id);
        if (Tool == null)
            return RedirectToPage("/Construction/NotFound");

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int id)
    {
        Tool deletedTool = await _toolService.DeleteToolAsync(id);
        if (deletedTool == null)
            return RedirectToPage("/Construction/NotFound");

        return RedirectToPage("/Product/ToolPages/GetAllTools");
    }
}


