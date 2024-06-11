using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NygarnDemo.EFDbContext;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;
using NygarnDemo.Services.ProductServices;

namespace NygarnDemo.Pages.Product.YarnPages
{
	[Authorize(Roles = "admin")]
	public class CreateYarnModel : PageModel
	{
		private IYarnService _yarnService;
		private IWebHostEnvironment _webHostEnvironment;

        [BindProperty]
		public Yarn Yarn { get; set; }

		public CreateYarnModel(IYarnService yarnService, IWebHostEnvironment webHost)
		{
			_yarnService = yarnService;
			_webHostEnvironment = webHost;
        }

		[BindProperty]
		public IFormFile? Photo { get; set; }

		public IActionResult OnGet()
		{
			return Page();
		}

        /// <summary>
        /// Metode der behandler HTTP-POST-anmodninger til siden
        /// </summary>
        /// <returns> ActionResult for siden, som brugeren skal omdirigeres til </returns>

		public async Task<IActionResult> OnPostAsync()
		{
            //Kontrollere om vores modelstate er gyldig
			if (!ModelState.IsValid)
			{
				return Page();
			}

            //Hvis der er uploadet et billede
            if (Photo != null)
            {
                //Hvis der allerede eksisterer et produktbillede på produktet, slettes det gamle
                if (Yarn.ProductImage != null)
                {
                    string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "/pngFiles", Yarn.ProductImage);
                    System.IO.File.Delete(filePath);
                }

                //Behandler det uploadede billede og gemmer stien til det i Yarn.ProductImage
                Yarn.ProductImage = ProcessUploadedFile();
            }

            //Tilføjer garnproduktet til databasen via AddYarnAsync metoden i YarnService
            await _yarnService.AddYarnAsync(Yarn);

            //Omdirigerer brugeren til siden med alle garnprodukterne
			return RedirectToPage("GetAllYarnProducts");
		}


        /// <summary>
        /// Metode til at behandle en uploadet fil
        /// </summary>
        /// <returns> Unikt filnavn for den uploadede fil</returns>
        private string ProcessUploadedFile()
        {
            string uniqueFileName = null;

            // Kontrollerer om der er valgt et billede
            if (Photo != null)
            {
                // Opretter stien til mappen, hvor filen skal gemmes
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "pngFiles");

                //Genererer et unikt filnavn ved at tilføje en GUID til det originale filnavn
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;

                // Opretter den fulde filsti for den uploadede fil.
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                // Kopierer den uploadede fil til den specificerede sti
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }

            // Returnerer det unikke filnavn for den uploadede fil
            return uniqueFileName;
        }

    }
}
