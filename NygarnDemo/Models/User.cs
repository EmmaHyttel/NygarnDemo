using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NygarnDemo.Models
{
    public class User : Person
    {
        //public string UserName { get; set; }
        //public string Password { get; set; }
        public List<Yarn> YarnWishList { get; set; }
        public User(string userName, string name, string lastName, string password, string address,
            string phone, string email) : base(userName, name, lastName, password, address, phone, email)
        {
            //YarnWishList = new List<Yarn>();
            //UserName = userName;
            //Password = password;
        }

        public User()
        {
            //UserName = userName;
            //Password = password;
        }
    }
}
