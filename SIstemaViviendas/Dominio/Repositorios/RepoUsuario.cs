using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Models;

namespace Dominio.Repositorios
{
    class RepoUsuario : IRepoUsuario
    {
        public bool add(Usuario u)
        {
            throw new NotImplementedException();
        }

        public Usuario buscarPorCi(int uCi)
        {
            throw new NotImplementedException();
        }

        public bool delete(Usuario u)
        {
            throw new NotImplementedException();
        }

        public bool login(Usuario u)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> traerTodos()
        {
            throw new NotImplementedException();
        }

        public bool update(Usuario u)
        {
            throw new NotImplementedException();
        }
    }
}
