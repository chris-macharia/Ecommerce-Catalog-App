using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceCatalog.Models
{
    public class Product
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required] // Cannot be empty
        [StringLength(100)] // Max 100 characters
        public string Name { get; set; } = string.Empty; //Gives a default value

        [StringLength(500)] // Optional, max 500 chars
        public string? Description { get; set; }

        [Required]
        [Range(0.01, 1000000)] // Price must be >= 0.01
        [Column(TypeName = "decimal(18,2)")] // Take in decimal places
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue)] // Stock cannot be negative
        public int Stock { get; set; }

        // Add the 'category' attribute to the products
        public int? CategoryId { get; set; } 
        public Category? Category { get; set; }

    }
}
