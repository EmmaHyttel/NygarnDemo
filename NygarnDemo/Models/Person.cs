namespace NygarnDemo.Models
{
    public class Person
    {

        public int PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Person(int personId, string name, string lastName, string password, string address, string phone)
        {

        }
        
    }
}
