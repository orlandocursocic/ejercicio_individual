using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_individual.Services
{
    public interface IEntradaService
    {
        Entrada Create(Entrada entrada);
        Entrada Read(long id);
        IQueryable<Entrada> ReadAll();
        void Update(Entrada entrada);
        Entrada Delete(long id);
    }
}
