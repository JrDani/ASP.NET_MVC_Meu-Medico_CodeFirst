using System.ComponentModel.DataAnnotations;

namespace Aprendendo.Models
{
    public class Especialidade
    {
        public int Id { get; set; }    
        [Required]
        public string Nome { get; set; }
    }
}