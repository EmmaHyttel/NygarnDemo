using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NygarnDemo.Models
{
    public class User
    {
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

        [Key]
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
        [Required(ErrorMessage = "Skriv kodeord minimum 8 tegn")]
        [MinLength(8)]
        public string Password { get; set; }

        [Display(Name = "Adresse")]
        [Required(ErrorMessage = "Mangler adresse")]
        [StringLength(100)]
        public string Address { get; set; }

        [Display(Name = "Telefon")]
        [Required(ErrorMessage = "Telefon nummer max 8 tegn")]
        [StringLength(8)]
        public string Phone { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "Mangler mail")]
        [StringLength(100)]
        public string Email { get; set; }



        public User(string userName, string name, string lastName, string password, string address, string phone, string email)
        {
            UserName = userName;
            Name = name;
            LastName = lastName;
            Password = password;
            Address = address;
            Phone = phone;
            Email = email;
        }

        public User()
        {
            //UserName = ""; 
            //Name = "";
            //LastName = "";
            //Password = "";
            //Address = "";
            //Phone = "";
            //Email = "";
        }
    }
}
