using Entities;
using System.Collections.Generic;

namespace Data.Repositiries.Abstract
{
    public interface IMoviesRepository
    {
        void AddMovie(MovieEntity movie);
        void UpdateMovie(MovieEntity movie);
        List<MovieEntity> GetAllMovies();
        void DeleteMovieById(int Id);
        void UpdateAllMovies(List<MovieEntity> movies);
    }
}
