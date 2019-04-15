using System.ComponentModel.DataAnnotations;

namespace Aprendendo.Models
{
    public class Estado
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sigla { get; set; }
        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }

    }
}