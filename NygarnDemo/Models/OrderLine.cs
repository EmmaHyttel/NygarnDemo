using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NygarnDemo.Models
{
    public class OrderLine
    {
        [Key, Column(Order = 0)]
        public int OrderId { get; set; }

        [Key, Column(Order = 1)]
        public int ProductId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [ForeignKey("ProductId")]
        public Yarn Yarn { get; set; }

        [ForeignKey("ProductId")]
        public Tool Tool { get; set; }

        [ForeignKey("ProductId")]
        public KnittingNeedle KnittingNeedle { get; set; }

        [ForeignKey("ProductId")]
        public CrochetHook CrochetHook { get; set; }

        [ForeignKey("ProductId")]
        public Pattern Pattern { get; set; }
    }
}
