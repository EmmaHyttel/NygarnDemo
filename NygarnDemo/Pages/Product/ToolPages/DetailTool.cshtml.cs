using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.ToolPages
{
    public class DetailToolModel : PageModel
    {

		private IToolService _toolService;

		public DetailToolModel(IToolService toolService)
		{
			_toolService = toolService;
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
    }
}
