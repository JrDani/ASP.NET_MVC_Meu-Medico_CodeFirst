using Aprendendo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo.Persistence
{
    interface IEspecialidadeDAO
    {
        void adicionar(Especialidade e);
        void editar(Especialidade e);
        void remover(Especialidade e);
        IList<Especialidade> Especialidades();
    }
}
