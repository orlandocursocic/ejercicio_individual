using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ejercicio_individual;
using ejercicio_individual.Services;

namespace ejercicio_individual.Controllers
{
    public class PeliculasController : ApiController
    {
        private IPeliculaService peliculasService;

        public PeliculasController(IPeliculaService peliculasService)
        {
            this.peliculasService = peliculasService;
        }

        // GET: api/Peliculas
        public IQueryable<Pelicula> GetPeliculas()
        {
            return peliculasService.ReadAll();
        }

        // GET: api/Peliculas/5
        [ResponseType(typeof(Pelicula))]
        public IHttpActionResult GetPelicula(long id)
        {
            Pelicula pelicula = peliculasService.Read(id);
            if (pelicula == null)
            {
                return NotFound();
            }

            return Ok(pelicula);
        }

        // PUT: api/Peliculas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPelicula(long id, Pelicula pelicula)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pelicula.Id)
            {
                return BadRequest();
            }

            try
            {
                peliculasService.Update(pelicula);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Peliculas
        [ResponseType(typeof(Pelicula))]
        public IHttpActionResult PostPelicula(Pelicula pelicula)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            pelicula = peliculasService.Create(pelicula);

            return CreatedAtRoute("DefaultApi", new { id = pelicula.Id }, pelicula);
        }

        // DELETE: api/Peliculas/5
        [ResponseType(typeof(Pelicula))]
        public IHttpActionResult DeletePelicula(long id)
        {
            Pelicula pelicula;
            try
            {
                pelicula = peliculasService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(pelicula);
        }
    }
}