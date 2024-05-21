using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NygarnDemo.Models
{
    public class SCLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SCLineId { get; set; }

        [ForeignKey("ProductId")]
        [Required]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int Count { get; set; }

        public SCLine(Product product, int count)
        {
            Product = product;
            Count = count;
        }

        public SCLine()
        {
        }
    }
}
