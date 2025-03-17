using System.ComponentModel.DataAnnotations;

namespace Studente.Models
{
    public class Student    
    {
        [Key]
        public required int Id { get; set; }

        [Required]
        [StringLength(50)]
        public required string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public required string Cognome { get; set; }

        [Required]
        public required DateTime DataDiNascita { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }
    }
}
