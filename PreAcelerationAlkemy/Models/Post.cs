using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreAcelerationAlkemy.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Denominación es requerido")]
        [StringLength(100)]
        public string Title { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
        [MinLength(1, ErrorMessage = "El campo {0} requiere almenos 1 caracter.")]
        public string Content { get; set; }
        public Usuario usuario { get; set; }
    }
}
