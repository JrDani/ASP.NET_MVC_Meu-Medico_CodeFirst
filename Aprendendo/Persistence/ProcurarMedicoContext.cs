using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aprendendo.Persistence
{
    public class ProcurarMedicoContext : DbContext
    {        
        public DbSet<Models.Cidade> Cidade { get; set; }
        public DbSet<Models.Medico> Medico { get; set; }
        public DbSet<Models.Especialidade> Especialidade { get; set; }
        public DbSet<Models.Usuario> Usuario { get; set; }
        public DbSet<Models.Pais> Pais { get; set; }
        public DbSet<Models.Estado> Estado { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\daniel\\Aprendendo\\Aprendendo\\App_Data\\Teste.mdf;Integrated Security=True");
        }
    }
}