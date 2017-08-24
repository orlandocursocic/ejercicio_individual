using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_individual.Repositories
{
    public interface IPeliculaRepository
    {
        Pelicula Create(Pelicula pelicula);
        Pelicula Read(long Id);
        IQueryable<Pelicula> ReadAll();
        void Update(Pelicula pelicula);
        Pelicula Delete(long Id);
    }
}
