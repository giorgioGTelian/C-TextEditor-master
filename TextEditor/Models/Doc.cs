using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TextEditor.Models
{
    public class Doc
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }

        [Required]
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public IdentityUser? User { get; set; }
    }
}
