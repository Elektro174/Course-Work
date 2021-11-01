using Data.Repositiries.Abstract;
using Domain;
using Mappers;
using Services.Abstract;
using System;
using System.Collections.Generic;

namespace Services
{
    public class MoviesService : IMoviesService
    {
        private readonly IMoviesRepository _moviesRepository;
        public MoviesService(IMoviesRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }
        public void AddMovie(Movie movie)
        {
            _moviesRepository.AddMovie(movie.ToEntity());
        }

        public void DeleteMovieById(int Id)
        {
            _moviesRepository.DeleteMovieById(Id);
        }

        public List<Movie> GetAllMovies()
        {
            throw new NotImplementedException();
        }

        public void UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
