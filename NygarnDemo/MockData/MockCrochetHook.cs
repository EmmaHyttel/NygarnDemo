using System.Drawing;
using System.Xml.Linq;

namespace NygarnDemo.MockData
{
    public class MockCrochetHook
    {
        private static List<Models.CrochetHook> _crochetHooks = new List<Models.CrochetHook>()
        {
            new Models.CrochetHook("Anodiseret aluminium", 2.0, 49.99, "Waves", "Soft grib", "KnitPro", 1),
            new Models.CrochetHook("Anodiseret aluminium", 2.0, 49.99, "Waves", "Soft grib", "KnitPro", 1),
            new Models.CrochetHook("Anodiseret aluminium", 2.0, 49.99, "Waves", "Soft grib", "KnitPro", 1)
        };

        public static List<Models.CrochetHook> GetAllCrocketHooks()
        {
            return _crochetHooks;
        }
    }
}
