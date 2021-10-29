using Data.Repositiries.Abstract;
using Domain;
using Mappers;
using Services.Abstract;
using System;

namespace Services
{
    public class DirectorsService : IDirectorsService
    {
        private readonly IDirectorsRepository _directorsRepository;
        public DirectorsService(IDirectorsRepository directorsRepository)
        {
             _directorsRepository = directorsRepository;
        }

        public void AddDirector(Director director)
        {
            _directorsRepository.AddDirector(director.ToEntity());
        }

        public void DeleteDirectorById(int Id)
        {
            throw new NotImplementedException();
        }

        public Director GetDirectorById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateDriver(Director director)
        {
            throw new NotImplementedException();
        }
    }
}
