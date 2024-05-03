using Microsoft.AspNetCore.Identity;
using NygarnDemo.Models;

namespace NygarnDemo.MockData
{
    public class MockUser
    {
        private static PasswordHasher<string> passwordHasher = new PasswordHasher<string>();

        private static List<User> _users = new List<User>()
        {
            new User(2, "ProKnitter", "Agnete", "Agnetesen",  passwordHasher.HashPassword(null, "123"), "Maglegaarsvej 2", "12345678", "Hveps@hotmail.com")

        };

        public static List<User> GetAllUsers()
        {
            return _users;
        }

        internal static List<User> GetMockUsers()
        {
            throw new NotImplementedException();
        }
    }
}
