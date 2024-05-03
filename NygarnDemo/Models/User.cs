using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NygarnDemo.Models
{
    public class User : Person
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UserName { get; set; }
        public string Password { get; set; }
        public User(int personId, string userName, string name, string lastName, string password, string address, string phone, string mail) : base(personId, userName, name, lastName, password, address, phone, mail)
        {
            UserName = userName;
            Password = password;
        }

        public User()
        {
            UserName = "";
            Password = "";
        }

    }
}
