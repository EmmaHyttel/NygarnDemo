using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NygarnDemo.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [Required]
        public int Id { get; set; } //UserId

        public User User { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        public Order()
        {
        }

        public Order(User user, Product product)
        {
            User = user;
            Product = product;
            Date = DateTime.Now;
        }



        //public virtual ICollection<OrderLine> OrderLines { get; set; }


    }

}
