using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PreAcelerationAlkemy.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [StringLength(100)]
        [Required]
        public string Password { get; set; }
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }
        public List<Post> Posts  { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
