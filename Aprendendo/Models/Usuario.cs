using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aprendendo.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}