using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAPI.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        
        public required string Nome { get; set; }

        
        [MaxLength(60)]
        public required string Email { get; set; }

        
        [MinLength(10)]
        [MaxLength(10)]
        public required string Senha { get; set; }
    }
}