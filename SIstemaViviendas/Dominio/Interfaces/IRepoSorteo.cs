using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Models;

namespace Dominio.Interfaces
{
    interface IRepoSorteo
    {
        bool add(Sorteo s);
        bool update(Sorteo s);
        bool delete(Sorteo s);
        Sorteo buscarPorId(int s_Id);
        IEnumerable<Sorteo> traerTodos();
    }
}
