using System.ComponentModel.DataAnnotations;

namespace Expenses.Mvc.Models
{
    public class Category
    {
        [Key]     
        public int Id { get; set; }

        [Required]
        [MaxLength(120)]
        [Display(Name ="Category Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(2)]
        [Display(Name = "Type")]
        public string Type { get; set; } = string.Empty;

        [Required]
        public bool Active { get; set; }
    }
}
