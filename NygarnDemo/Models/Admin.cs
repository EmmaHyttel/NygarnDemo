using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace NygarnDemo.Models
{
    [Authorize(Roles = "admin")]
    public class Admin : Person
    {

        [Display(Name = "Skriv et ønskede brugernavn")]
        [Required(ErrorMessage = "Brugernavn må max indeholde 50 tegn")]   //brugernavn taget - throw exception. 
        [StringLength(30)]
        public string UserName { get; set; }


        [Display(Name = "Skriv ønskede kodeord")]
        [Required(ErrorMessage = "Skriv kodeord max 50 tegn")]
        [StringLength(50)]
        public string Password { get; set; }

        public Admin(int personId, string userName, string name, string lastName, string password, string address, string phone) : base(personId, userName, name, lastName, password, address, phone)
        {
        }
    }
}
