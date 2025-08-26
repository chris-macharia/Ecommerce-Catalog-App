using System.ComponentModel.DataAnnotations;

namespace EcommerceCatalog.Models
{
    public class Category
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty; //Gives a default value

        // One Category can have many Products
        public ICollection<Product>? Products { get; set; }
    }
}
