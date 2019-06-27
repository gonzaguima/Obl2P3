using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Models;

namespace Dominio.Interfaces
{
    interface IRepoVivienda
    {
        bool add(Vivienda v);
        bool update(Vivienda v);
        bool delete(Vivienda v);
        Vivienda buscarPorId(int v_id);
        IEnumerable<Barrio> traerTodos();
    }
}
