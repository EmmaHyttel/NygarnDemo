using NygarnDemo.Models;

namespace NygarnDemo.MockData
{
    public class MockAdmin
    {
        private static List<Admin> _admins = new List<Admin>()
        {
            new Admin(2, "ProKnitter", "Agnete", "Agnetesen", "1234", "Maglegaarsvej 2", "12345678")

        };

        public static List<Admin> GetAllAdmins()
        {
            return _admins;
        }

        internal static List<Admin>? GetAdmins()
        {
            throw new NotImplementedException();
        }
    }
}
