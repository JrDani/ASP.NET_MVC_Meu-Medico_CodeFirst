using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aprendendo.Models;
using Microsoft.EntityFrameworkCore;

namespace Aprendendo.Persistence
{
    public class MedicoDAO : IMedicoDAO
    {
        private ProcurarMedicoContext contexto;

        public MedicoDAO()
        {
            this.contexto = new ProcurarMedicoContext();
        }

        public void adicionar(Medico m)
        {
            using (this.contexto)
            {
                contexto.Medico.Add(m);
                contexto.SaveChanges();
            }
        }

        public void editar(Medico m)
        {
            using (this.contexto)
            {
                contexto.Medico.Update(m);
                contexto.SaveChanges();
            }
        }

        public IList<Medico> Medicos()
        {
            using (this.contexto)
            {
                return contexto.Medico
                    .Include(t => t.Cidade)
                    .Include(t => t.Especialidade)
                    .ToList();                   
            }
        }

        public IList<Medico> busca(int cidade, int especialidade)
        {
            using (this.contexto)
            {
               return this.contexto.Medico
                        .Include(t => t.Cidade)
                        .Include(t => t.Especialidade)
                        .Where(
                            m =>
                            (cidade == 0 || m.CidadeId == cidade) &&
                            (especialidade == 0 || m.EspecialidadeId == especialidade)
                        ).ToList();
            }
        } 

        public void remover(Medico m)
        {
            using (this.contexto)
            {
                contexto.Medico.Remove(m);
                contexto.SaveChanges();
            }
        }       
    }
}