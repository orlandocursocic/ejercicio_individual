using ejercicio_individual.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicio_individual.Services
{
    public class EntradaService : IEntradaService
    {
        private IEntradaRepository entradaRepository;

        public EntradaService(IEntradaRepository entradaRepository)
        {
            this.entradaRepository = entradaRepository;
        }

        public Entrada Create(Entrada entrada)
        {
            return entradaRepository.Create(entrada);
        }

        public Entrada Delete(long id)
        {
            return entradaRepository.Delete(id);
        }

        public Entrada Read(long id)
        {
            return entradaRepository.Read(id);
        }

        public IQueryable<Entrada> ReadAll()
        {
            return entradaRepository.ReadAll();
        }

        public void Update(Entrada entrada)
        {
            entradaRepository.Update(entrada);
        }
    }
}