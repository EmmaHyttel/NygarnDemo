using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace NygarnDemo.Models
{
    public class Person
    {

        public int PersonId { get; set; }

        [Display(Name = "Skriv et ønskede brugernavn")]
        [Required(ErrorMessage = "Brugernavn må max indeholde 50 tegn")]   //brugernavn taget - throw exception. 
        [StringLength(30)]
        public string UserName { get; set; }

        [Display(Name = "Fornavn")]
        [Required(ErrorMessage = "Mangler fornavn")]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Efternavn")]
        [Required(ErrorMessage = "Mangler efternavn")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Display(Name = "Skriv ønskede kodeord")]
        [Required(ErrorMessage = "Skriv kodeord max 50 tegn")]
        [StringLength(50)]
        public string Password { get; set; }

        [Display(Name = "Adresse")]
        [Required(ErrorMessage = "Mangler adresse")]
        [StringLength(100)]
        public string Address { get; set; }

        [Display(Name = "Telefon")]
        [Required(ErrorMessage = "Telefon nummer max 8 tegn")]
        [StringLength(8)]
        public string Phone { get; set; }

        public Person(int personId, string userName, string name, string lastName, string password, string address, string phone)
        {
            UserName = userName;
            Name = name;
            LastName = lastName;
            Password = password;
            Address = address;
            Phone = phone;
        }

        public Person()
        {
            UserName = ""; 
            Name = "";
            LastName = "";
            Password = "";
            Address = "";
            Phone = "";
        }
    }
}
