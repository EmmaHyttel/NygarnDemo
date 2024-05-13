using Microsoft.AspNetCore.Identity;
using NygarnDemo.Models;
using Microsoft.Extensions.DependencyInjection;

namespace NygarnDemo.MockData
{
    public class MockUser
    {
        private static PasswordHasher<string> passwordHasher = new PasswordHasher<string>();

        private static List<User> _users = new List<User>()

        {
            new User("ProKnitter", "Agnete", "Agnetesen",  passwordHasher.HashPassword(null, "123"), "Maglegaarsvej 2", 
                "12345678", "Hveps@hotmail.com"),
            new User("Admin", "Chef", "Chefsen",  passwordHasher.HashPassword(null, "321"), "Maglegaarsvej 2", 
                "87654321", "Lampetossen@hotmail.com")
            //new User("Mai", passwordHasher.HashPassword(null, "Nanna123")),
            //new User("admin", passwordHasher.HashPassword(null, "Emma"))

        };

        public static List<User> GetAllUsers()
        {
            return _users;
        }
    }
}
