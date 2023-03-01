using System.ComponentModel.DataAnnotations;

namespace Tarnasi.Models
{
    public class Category
    {
        public long Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string? Name { get; set; }

        public List<Category>? Categories { get; set; }
        public List<Article>? Articles { get; set; }
    }
}