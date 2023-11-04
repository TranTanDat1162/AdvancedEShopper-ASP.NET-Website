using System.ComponentModel.DataAnnotations;

namespace AdvancedEShopper.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string? CategoryName { get; set; }
        [StringLength(300)]
        public string? CategoryPhoto { get; set; }
        public int CategoryOrder { get; set; }
    }
}
