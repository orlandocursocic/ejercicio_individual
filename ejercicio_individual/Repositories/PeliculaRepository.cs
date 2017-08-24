using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ejercicio_individual.Repositories
{
    public class PeliculaRepository : IPeliculaRepository
    {
        public Pelicula Create(Pelicula pelicula)
        {
            return ApplicationDbContext.applicationDbContext.Peliculas.Add(pelicula);
        }

        public Pelicula Delete(long Id)
        {
            Pelicula pelicula = ApplicationDbContext.applicationDbContext.Peliculas.Find(Id);
            if (pelicula == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.Peliculas.Remove(pelicula);
            return pelicula;
        }

        public Pelicula Read(long Id)
        {
            return ApplicationDbContext.applicationDbContext.Peliculas.Find(Id);
        }

        public IQueryable<Pelicula> ReadAll()
        {
            IList<Pelicula> lista = new List<Pelicula>(ApplicationDbContext.applicationDbContext.Peliculas);

            return lista.AsQueryable();
        }

        public void Update(Pelicula pelicula)
        {
            if (ApplicationDbContext.applicationDbContext.Peliculas.Count(p => p.Id == pelicula.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(pelicula).State = EntityState.Modified;
        }
    }
}