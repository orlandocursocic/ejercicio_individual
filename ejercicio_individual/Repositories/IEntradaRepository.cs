using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_individual.Repositories
{
    public interface IEntradaRepository
    {
        Entrada Create(Entrada entrada);
        Entrada Read(long Id);
        IQueryable<Entrada> ReadAll();
        void Update(Entrada entrada);
        Entrada Delete(long Id);
    }
}
