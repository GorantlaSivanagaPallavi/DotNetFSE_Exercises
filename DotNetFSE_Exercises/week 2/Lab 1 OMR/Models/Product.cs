using System.ComponentModel.DataAnnotations;

namespace Exercise_01_RetailInventorySystem.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}