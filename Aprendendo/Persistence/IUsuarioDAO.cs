using Aprendendo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aprendendo.Persistence
{
    interface IUsuarioDAO
    {
        Usuario busca(string username, string password);       
    }
}