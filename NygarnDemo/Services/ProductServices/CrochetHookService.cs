using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Pages.Product.CrochetHookPages;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Services.ProductServices
{
    public class CrochetHookService : ICrochetHookService
    {
        public List<CrochetHook> CrochetHooks { get; set; }

        public CrochetHookService()
        {
            CrochetHooks = MockCrochetHook.GetAllCrochetHooks();
        }

        public List<CrochetHook> GetCrochetHooks()
        {
            return CrochetHooks;
        }
    }
}
