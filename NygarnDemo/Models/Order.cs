using System.ComponentModel.DataAnnotations;

namespace NygarnDemo.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
