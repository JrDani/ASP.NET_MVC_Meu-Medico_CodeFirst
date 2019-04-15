using System.ComponentModel.DataAnnotations;

namespace Aprendendo.Models
{
    public class Pais
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sigla { get; set; }
    }
}