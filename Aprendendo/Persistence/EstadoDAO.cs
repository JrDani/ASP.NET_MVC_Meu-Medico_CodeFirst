using System.Collections.Generic;
using System.Linq;
using Aprendendo.Models;
using Aprendendo.Persistence;

namespace Aprendendo.Controllers
{
    internal class EstadoDAO : IEstadoDAO
    {

        private ProcurarMedicoContext contexto;

        public EstadoDAO()
        {
            this.contexto = new ProcurarMedicoContext();
        }

        public void adicionar(Estado e)
        {
            using (this.contexto)
            {
                contexto.Estado.Add(e);
                contexto.SaveChanges();
            }
        }

        public IList<Estado> Estados()
        {
            using (this.contexto)
            {
                return contexto.Estado.ToList();
            }
        }

        public void editar(Estado e)
        {
            using (this.contexto)
            {
                contexto.Estado.Update(e);
                contexto.SaveChanges();
            }
        }

        public void remover(Estado e)
        {
            using (this.contexto)
            {
                contexto.Estado.Remove(e);
                contexto.SaveChanges();
            }
        }
    }
}