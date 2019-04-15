using Aprendendo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo.Persistence
{
    interface IMedicoDAO
    {
        void adicionar(Medico m);
        void editar(Medico m);
        void remover(Medico m);
        IList<Medico> Medicos();
    }
}
