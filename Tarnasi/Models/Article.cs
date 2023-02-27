using Microsoft.AspNetCore.Components.Web.Virtualization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tarnasi.Models
{
    public class Article
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string Slug { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public string? Url { get; set; }
        public DateTime published_at = DateTime.Now;

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public long CategoryId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public long UserId { get; set; }
    }
}
