using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NygarnDemo.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        public List<ShoppingCartLine> OrderLInes { get; set; } = new List<ShoppingCartLine>();

        public Order(DateTime date)
        {
            Date = date;

        }

        public Order()
        {
        }
    }

}
