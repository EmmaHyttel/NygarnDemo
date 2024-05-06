using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NygarnDemo.Models
{
    public class User : Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UserName { get; set; }
        public string Password { get; set; }
        //public User(int personId, string userName, string name, string lastName, string password, string address, string phone, string email) : base(personId, userName, name, lastName, password, address, phone, email)
        //{
        //    UserName = userName;
        //    Password = password;
        //}

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
