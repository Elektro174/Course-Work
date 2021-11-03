using Data.Repositiries.Abstract;
using Entities;
//using Json.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace Data.Repositiries
{
    public class MoviesRepository : IMoviesRepository
    {
        const string JSON_FILE_PATH = "C:/Users/glebn/source/repos/Course-Work/test.json";
        public void AddMovie(MovieEntity movie)
        {
            List<MovieEntity> _movies = new List<MovieEntity>();

            _movies = GetAllMovies();
            if (_movies == null)
            {
                List<MovieEntity> firstMovie = new List<MovieEntity>();
                movie.CreatedDdate = DateTime.Now;
                firstMovie.Add(movie);
                File.AppendAllText(JSON_FILE_PATH, JsonConvert.SerializeObject(firstMovie));
                return;
            }
            var last = _movies.Count;
            movie.Id = last++;
            movie.CreatedDdate = DateTime.UtcNow;
            _movies.Add(movie);
            UpdateAllMovies(_movies);
            //StreamReader r = new StreamReader(JSON_FILE_PATH);
            // string json = r.ReadToEnd();
            // List<MovieEntity> movies = JsonConvert.DeserializeObject<List<MovieEntity>>(json);
            // r.Close();
            // if (movies == null)
            //  {
            //   List<MovieEntity> firstMovie = new List<MovieEntity>();
            //     firstMovie.Add(movie);
            //    File.AppendAllText(JSON_FILE_PATH, JsonConvert.SerializeObject(firstMovie));
            //   return;
            // }
            // movies.Add(movie);
            //   File.AppendAllText(JSON_FILE_PATH, JsonConvert.SerializeObject(movies));



            // File.WriteAllText("C:/Users/glebn/source/repos/Course-Work/test.json", String.Empty);


            //Console.WriteLine(JsonConvert.SerializeObject(movie));
        }

        public void DeleteMovieById(int Id)
        {
            List<MovieEntity> _movies = new List<MovieEntity>();
            _movies = GetAllMovies();

            // List<MovieEntity> movies = JsonConvert.DeserializeObject<List<MovieEntity>>(json);
            _movies.RemoveAt(Id);
            UpdateAllMovies(_movies);
            //File.WriteAllText("C:/Users/glebn/source/repos/Course-Work/test.json", String.Empty);
            // File.AppendAllText("C:/Users/glebn/source/repos/Course-Work/test.json", JsonConvert.SerializeObject(_movies));

        }

        public List<MovieEntity> GetAllMovies()
        {
            List<MovieEntity> _movies = new List<MovieEntity>();
            StreamReader r = new StreamReader(JSON_FILE_PATH);
            string json = r.ReadToEnd();
            _movies = JsonConvert.DeserializeObject<List<MovieEntity>>(json);
            r.Close();
            return _movies;
        }

        public void UpdateAllMovies(List<MovieEntity> _movies)
        {
            List<MovieEntity> movies = new List<MovieEntity>();
            movies = _movies;
            File.WriteAllText(JSON_FILE_PATH, String.Empty);
            File.AppendAllText(JSON_FILE_PATH, JsonConvert.SerializeObject(movies));
        }

        public void UpdateMovie(MovieEntity movie)
        {
            throw new NotImplementedException();
        }
    }
}
