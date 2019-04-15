using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aprendendo.Models;

namespace Aprendendo.Persistence
{
    public class CidadeDAO : ICidadeDAO
    {
        public ProcurarMedicoContext contexto { get; set; }

        public CidadeDAO()
        {
            this.contexto = new ProcurarMedicoContext();
        }

        public void adicionar(Cidade c)
        {
            using (this.contexto)
            {
                this.contexto.Add(c);
                this.contexto.SaveChanges();
            }
        }

        public IList<Cidade> Cidades()
        {
            using (this.contexto)
            {
                return this.contexto.Cidade.ToList();
            }
        }       

        public void editar(Cidade c)
        {
            using (this.contexto)
            {
                this.contexto.Update(c);
                this.contexto.SaveChanges();
            }
        }

        public void remover(Cidade c)
        {
            using (this.contexto)
            {
                this.contexto.Remove(c);
                this.contexto.SaveChanges();
            }
        }
    }
}