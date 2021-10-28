using Data.Repositiries.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositiries
{
    public class MoviesRepository : IMoviesRepository
    {
        public void AddMovie(MovieEntity movie)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovieById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<MovieEntity> GetAllMovies()
        {
            throw new NotImplementedException();
        }

        public void UpdateMovie(MovieEntity movie)
        {
            throw new NotImplementedException();
        }
    }
}
