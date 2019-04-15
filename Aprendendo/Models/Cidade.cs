using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aprendendo.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        [Required]
        public String Nome { get; set; }
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }

    }
}