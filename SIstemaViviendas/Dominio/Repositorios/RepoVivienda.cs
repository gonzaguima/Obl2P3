using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Models;

namespace Dominio.Repositorios
{
    public class RepoVivienda : IRepoVivienda
    {
        public bool add(Vivienda v)
        {
            throw new NotImplementedException();
        }

        public Vivienda buscarPorId(int v_id)
        {
            throw new NotImplementedException();
        }

        public bool delete(Vivienda v)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Barrio> traerTodos()
        {
            throw new NotImplementedException();
        }

        public bool update(Vivienda v)
        {
            throw new NotImplementedException();
        }
    }
}
