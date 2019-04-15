using Aprendendo.Models;
using System.Collections.Generic;

namespace Aprendendo.Controllers
{
    internal interface IEstadoDAO
    {
        void adicionar(Estado e);
        void editar(Estado e);
        void remover(Estado e);
        IList<Estado> Estados();
    }
}