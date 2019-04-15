using System.Collections.Generic;
using System.Linq;
using Aprendendo.Models;
using Aprendendo.Persistence;

namespace Aprendendo.Controllers
{
    internal class PaisDAO : IPaisDAO
    {
        private ProcurarMedicoContext contexto;

        public PaisDAO()
        {
            this.contexto = new ProcurarMedicoContext();
        }

        public void adicionar(Pais p)
        {
            using (this.contexto)
            {
                contexto.Pais.Add(p);
                contexto.SaveChanges();
            }
        }

        public void editar(Pais p)
        {
            using (this.contexto)
            {
                contexto.Pais.Update(p);
                contexto.SaveChanges();
            }
        }

        public IList<Pais> Paises()
        {
            return this.contexto.Pais.ToList();
        }

        public void remover(Pais p)
        {
            using (this.contexto)
            {
                contexto.Pais.Remove(p);
                contexto.SaveChanges();
            }
        }
    }
}