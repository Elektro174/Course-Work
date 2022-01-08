using Domain;
using System.Collections.Generic;

namespace Services.Abstract
{
    public interface IMoviesService
    {
        void AddMovie(Movie movie);
        List<Movie> GetAllMovies();
        void DeleteMovieById(int Id);
        void UpdateAllMovies(List<Movie> movies);
    }
}