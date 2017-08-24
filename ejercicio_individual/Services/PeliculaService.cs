using ejercicio_individual.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicio_individual.Services
{
    public class PeliculaService : IPeliculaService
    {
        private IPeliculaRepository peliculaRepository;

        public PeliculaService(IPeliculaRepository peliculaRepository)
        {
            this.peliculaRepository = peliculaRepository;
        }

        public Pelicula Create(Pelicula pelicula)
        {
            return peliculaRepository.Create(pelicula);
        }

        public Pelicula Delete(long id)
        {
            return peliculaRepository.Delete(id);
        }

        public Pelicula Read(long id)
        {
            return peliculaRepository.Read(id);
        }

        public IQueryable<Pelicula> ReadAll()
        {
            return peliculaRepository.ReadAll();
        }

        public void Update(Pelicula pelicula)
        {
            peliculaRepository.Update(pelicula);
        }
    }
}