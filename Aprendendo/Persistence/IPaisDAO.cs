using Aprendendo.Models;
using System.Collections.Generic;

namespace Aprendendo.Controllers
{
    internal interface IPaisDAO
    {
        void adicionar(Pais p);
        void editar(Pais p);
        void remover(Pais p);
        IList<Pais> Paises();
    }
}