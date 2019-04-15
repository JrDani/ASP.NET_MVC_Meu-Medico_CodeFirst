using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aprendendo.Models
{
    public class Medico
    {
        public int Id { get; set; }
        [Required]
        public string CRM { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public Boolean AtendePorConvenio { get; set; }
        [Required]
        public Boolean TemClinica { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public int CidadeId { get; set; }        
        public virtual Cidade Cidade { get; set; }        
        public int EspecialidadeId { get; set; }       
        public virtual Especialidade Especialidade { get; set; }
    }    
}