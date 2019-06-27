using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Models;

namespace Dominio.Interfaces
{
    interface IRepoUsuario
    {
        bool add(Usuario u);
        bool update(Usuario u);
        bool delete(Usuario u);
        Usuario buscarPorCi(int uCi);
        IEnumerable<Usuario> traerTodos();

        bool login(Usuario u);
    }
}
