using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Services.ProductServices
{
    public class YarnService : IYarnService
    {
        public List<Yarn>? YarnProducts { get; set; }

        public YarnService()
        {
            YarnProducts = MockYarn.GetAllYarnProducts();
        }


        public List<Yarn> GetYarnProducts()
        {
            return YarnProducts;
        }

   
    }
}
