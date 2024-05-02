namespace NygarnDemo.Models
{
    public class User : Person
    {
        private string WishList { get; set; }   


        public User(int personId, string userName, string name, string lastName, string password, string address, string phone) : base(personId, userName, name, lastName, password, address, phone)
        {
            
            Name = name;
            LastName = lastName;
            Password = password;
            Address = address;
            Phone = phone; 
        }
    }
}
