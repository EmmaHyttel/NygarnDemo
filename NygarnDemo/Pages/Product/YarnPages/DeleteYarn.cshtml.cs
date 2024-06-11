using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Pages.Product.YarnPages
{
    [Authorize(Roles = "admin")]
    public class DeleteYarnModel : PageModel
    {
        private IYarnService _yarnService;

        public DeleteYarnModel(IYarnService YarnService)
        {
            _yarnService = YarnService;
        }

        [BindProperty]
        public Models.Yarn Yarn { get; set; }
    
        /// <summary>
        /// Håndtere HTTP GET-anmodninger til siden og henter garnet med det angivet id
        /// </summary>
        /// <param name="id"> id'et for det garn, der skal slettes</param>
        /// <returns>ActionResult for siden</returns>

        public async Task<IActionResult> OnGet(int id)
        {
            //Henter garnet med det angivet id fra YarnService via GetYarn metoden
            Yarn = await _yarnService.GetYarn(id);

            //Hvis garnet ikke findes, omdirigeres brugeren til en NotFound side
            if (Yarn == null)
                return RedirectToPage("/Construction/NotFound");

            //Returnere siden
            return Page();
        }

        /// <summary>
        /// Håndterer HTTP POST-anmodninger til siden for at slette garn med det angivede id
        /// </summary>
        /// <param name="id">Id for det garn, der skal slettes</param>
        /// <returns>ActionResult for omdirigering efter sletning</returns>
        public async Task<IActionResult> OnPostAsync(int id)
        {
            //Sletter garnet med det angivet id via DeleteYarnAsync metoden i YarnService
            Models.Yarn deletedYarn = await _yarnService.DeleteYarnAsync(id);

            //Hvus det slettede garn ikke findes, omdirigeres brugeren til en NotFound side
            if (deletedYarn == null)
                return RedirectToPage("/Construction/NotFound");

            //Efter sletningen omdirigeres brugeren til siden med alle garnprodukterne
            return RedirectToPage("GetAllYarnProducts");
        }
    }
}
