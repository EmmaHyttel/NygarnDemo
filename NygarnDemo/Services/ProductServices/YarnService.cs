using NygarnDemo.MockData;
using NygarnDemo.Models;

namespace NygarnDemo.Services.ProductServices
{
    public class YarnService
    {
        private List<Yarn> _yarnProducts;

        public YarnService()
        {
            _yarnProducts = MockYarn.GetMockYarn();
        }

    }
}
