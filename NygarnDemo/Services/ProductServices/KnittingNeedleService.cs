using NygarnDemo.MockData;
using NygarnDemo.Models;
using NygarnDemo.Services.Interfaces;

namespace NygarnDemo.Services.ProductServices
{
    public class KnittingNeedleService : IKnittingNeedleService
    {
     

        public List<KnittingNeedle> _knittingNeedle { get; set; }

        public KnittingNeedleService()
        {
            _knittingNeedle = MockKnittingNeedle.GetAllKnittingNeedles();
        }

        public List<KnittingNeedle> GetKnittingNeedles()
        {
            return _knittingNeedle;
        }

 


    }
}