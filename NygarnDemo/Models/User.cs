namespace NygarnDemo.Models
{
    public class User : Person
    {
        public User(int personId, string userName, string name, string lastName, string password, string address, string phone, string mail) : base(personId, userName, name, lastName, password, address, phone, mail)
        {
        }
    }
}
