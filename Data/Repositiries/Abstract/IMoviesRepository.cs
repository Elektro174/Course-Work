using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositiries.Abstract
{
    public interface IMoviesRepository
    {
        void AddMovie(MovieEntity movie);
        void UpdateMovie(MovieEntity movie);
        List<MovieEntity> GetAllMovies();
        void DeleteMovieById(int Id);
    }
}
