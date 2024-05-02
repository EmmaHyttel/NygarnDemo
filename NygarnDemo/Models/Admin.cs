using Microsoft.AspNetCore.Authorization;

namespace NygarnDemo.Models
{
    [Authorize(Roles = "admin")]
    public class Admin : Person
    {

        public Admin(int personId, string userName, string name, string lastName, string password, string address, string phone) : base(personId, userName, name, lastName, password, address, phone)
        {
        }
    }
}
