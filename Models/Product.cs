using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvancedEShopper.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(150)]
        public string? ProductName { get; set; }
        [StringLength(3000)]
        public string? ProductDescription { get; set; }
        public string? CategoryId { get; set; }
        [Column(TypeName = "decimal(8,2")]
        public decimal? ProductPrice { get; set; }
        public decimal? ProductDiscount { get; set;}
        public string? ProductPhoto { get; set;}
        public int SizeId { get; set; }
        public int ColorId { get; set; }
        public bool IsTrendy { get; set; }
        public bool IsArrived { get; set; }
    }
}
