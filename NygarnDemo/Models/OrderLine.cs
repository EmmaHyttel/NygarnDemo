using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NygarnDemo.Models
{
    public class OrderLine
    {
        [Key, Column(Order = 0)]
        public int OrderId { get; set; }

        //[Key, Column(Order = 1)]
        public int ProductId { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [ForeignKey("ProductId")]
        public virtual Yarn Yarn { get; set; }

        [ForeignKey("ProductId")]
        public virtual Tool Tool { get; set; }

        [ForeignKey("ProductId")]
        public virtual KnittingNeedle KnittingNeedle { get; set; }

        [ForeignKey("ProductId")]
        public virtual CrochetHook CrochetHook { get; set; }

        [ForeignKey("ProductId")]
        public virtual Pattern Pattern { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int Count { get; set; }
    }
}
