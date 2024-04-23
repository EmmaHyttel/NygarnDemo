using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Services.ProductServices
{
    public class YarnService : IYarnService
    {
        public List<Yarn>? yarnProducts { get; set; }

        public YarnService(List<Yarn>? yarnProducts)
        {
            yarnProducts = MockYarn.GetMockYarn();
        }


        public List<Yarn> GetYarnProducts()
        {
            return yarnProducts;
        }
    }
}
