using Data.Repositiries.Abstract;
using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Data.Repositiries
{
    public class MoviesRepository : IMoviesRepository
    {
        public void AddMovie(MovieEntity movie)
        {
            File.WriteAllText("C:/Users/glebn/source/repos/Course-Work/test.json", String.Empty);
            File.AppendAllText("C:/Users/glebn/source/repos/Course-Work/test.json", JsonConvert.SerializeObject(movie));
            Console.WriteLine(JsonConvert.SerializeObject(movie));
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
