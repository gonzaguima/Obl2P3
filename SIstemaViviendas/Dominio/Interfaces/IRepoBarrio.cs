using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Models;

namespace Dominio.Interfaces
{
    interface IRepoBarrio
    {
        bool add(Barrio b);
        bool update(Barrio b);
        bool delete(Barrio b);
        Barrio buscarPorNombre(string b_nombre);
        IEnumerable<Barrio> traerTodos();
    }
}
