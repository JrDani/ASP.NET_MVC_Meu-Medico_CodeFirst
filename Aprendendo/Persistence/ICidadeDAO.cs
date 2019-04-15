using Aprendendo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo.Persistence
{
    interface ICidadeDAO
    {
        void adicionar(Cidade c);
        void editar(Cidade c);
        void remover(Cidade c);
        IList<Cidade> Cidades();
    }
}
