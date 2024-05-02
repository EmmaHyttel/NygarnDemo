using System.ComponentModel.DataAnnotations;

namespace NygarnDemo.Models
{
    public class User : Person
    {
        private string WishList { get; set; }

        [Display(Name = "Skriv et ønskede brugernavn")]
        [Required(ErrorMessage = "Brugernavn må max indeholde 50 tegn")]   //brugernavn taget - throw exception. 
        [StringLength(30)]
        public string UserName { get; set; }

        [Display(Name = "Skriv ønskede kodeord")]
        [Required(ErrorMessage = "Skriv kodeord max 50 tegn")]
        [StringLength(50)]
        public string Password { get; set; }


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
