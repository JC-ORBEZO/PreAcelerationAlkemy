using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreAcelerationAlkemy.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(100, ErrorMessage ="El campo {0} permite hasta 100 caracteres.")]
        [MinLength(1, ErrorMessage = "El campo {0} requiere almenos un caracter.")]
        public string Comentario { get; set; }
    }
}
