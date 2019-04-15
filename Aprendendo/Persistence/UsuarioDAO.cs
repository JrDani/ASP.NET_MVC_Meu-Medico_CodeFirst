using Aprendendo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aprendendo.Persistence
{
    public class UsuarioDAO : IUsuarioDAO
    {
        public ProcurarMedicoContext contexto { get; set; }

        public UsuarioDAO()
        {
            this.contexto = new ProcurarMedicoContext();
        }

        public Usuario busca(string username, string password)
        {
            using (this.contexto)
            {
                return this.contexto.Usuario.Where(
                        u => 
                        (u.Username == username)
                        && (u.Password == password) 
                    ).FirstOrDefault();
            }
        }        
    }
}