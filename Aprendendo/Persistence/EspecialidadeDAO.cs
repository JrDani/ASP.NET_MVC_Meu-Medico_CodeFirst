using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aprendendo.Models;

namespace Aprendendo.Persistence
{
    public class EspecialidadeDAO : IEspecialidadeDAO
    {
        public ProcurarMedicoContext contexto { get; set; }

        public EspecialidadeDAO()
        {
            this.contexto = new ProcurarMedicoContext();
        }

        public void adicionar(Especialidade e)
        {
            using (this.contexto)
            {
                this.contexto.Add(e);
                this.contexto.SaveChanges();
            }
        }

        public void Dispose()
        {
            using (this.contexto)
            {
                this.contexto.Dispose();
            }
        }

        public void editar(Especialidade e)
        {
            using (this.contexto)
            {
                this.contexto.Update(e);
                this.contexto.SaveChanges();
            }
        }

        public IList<Especialidade> Especialidades()
        {
            using (this.contexto)
            {
                return this.contexto.Especialidade.ToList();
            }
        }

        public void remover(Especialidade e)
        {
            using (this.contexto)
            {
                this.contexto.Remove(e);
                this.contexto.SaveChanges();
            }
        }
    }
}