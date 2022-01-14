using System.ComponentModel.DataAnnotations;

namespace ExamDotnet.Models
{
    public class Product
    {
        [Key]
        public string Code { get; set; }
        public string Designation { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be positive")]
        public int Quantity { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Unit price must be positive")]
        public double UnitPrice { get; set; }
    }
}