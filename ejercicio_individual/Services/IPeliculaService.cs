using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_individual.Services
{
    public interface IPeliculaService
    {
        Pelicula Create(Pelicula pelicula);
        Pelicula Read(long id);
        IQueryable<Pelicula> ReadAll();
        void Update(Pelicula pelicula);
        Pelicula Delete(long id);
    }
}
