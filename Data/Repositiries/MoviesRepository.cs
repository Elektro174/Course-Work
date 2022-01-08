using Data.Repositiries.Abstract;
using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Data.Repositiries
{
    public class MoviesRepository : IMoviesRepository
    {
        static string projectRoot = AppDomain.CurrentDomain.BaseDirectory
      .TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar)
      .AsObjectSequence(path => Path.GetDirectoryName(path))
      .Where(path => Directory.EnumerateFiles(path, "*.json").Any())
      .First();
        static string jsonFileName = Path.Combine(projectRoot, "MoviesList.json");
        static string txtFileName = Path.Combine(projectRoot, "LastId.txt");
        string JSON_FILE_PATH = jsonFileName;
        string LAST_ID_FILE_PATH = txtFileName;
        public void AddMovie(MovieEntity movie)
        {
            List<MovieEntity> _movies = new List<MovieEntity>();

            _movies = GetAllMovies();
            if (_movies == null)
            {
                List<MovieEntity> firstMovie = new List<MovieEntity>();
                movie.CreatedDdate = DateTime.Now.ToString();
                movie.Id = 1;
                firstMovie.Add(movie);
                File.AppendAllText(JSON_FILE_PATH, JsonConvert.SerializeObject(firstMovie));
                File.WriteAllText(LAST_ID_FILE_PATH, string.Empty);
                File.AppendAllText(LAST_ID_FILE_PATH, "1");
                return;
            }
            movie.Id = Convert.ToInt32(File.ReadAllText(LAST_ID_FILE_PATH)) + 1;
            movie.CreatedDdate = DateTime.Now.ToString();
            _movies.Add(movie);
            UpdateAllMovies(_movies);
            int Last = movie.Id;

            File.WriteAllText(LAST_ID_FILE_PATH, string.Empty);
            File.AppendAllText(LAST_ID_FILE_PATH, Last.ToString());
        }

        public void DeleteMovieById(int Id)
        {
            List<MovieEntity> _movies = new List<MovieEntity>();
            _movies = GetAllMovies();
            _movies.Remove(_movies.Find(movie => movie.Id == Id));
            UpdateAllMovies(_movies);
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
    }
}