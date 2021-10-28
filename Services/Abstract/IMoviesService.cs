using Domain;
using System.Collections.Generic;

namespace Services.Abstract
{
    public interface IMoviesService
    {
        void AddMovie(Movie movie);
        void UpdateMovie(Movie movie);
        List<Movie> GetAllMovies();
        void DeleteMovieById(int Id);
    }
}
