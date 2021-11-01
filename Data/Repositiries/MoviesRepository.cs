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
        public void AddMovie(MovieEntity movie)
        {
            StreamReader r = new StreamReader("C:/Users/glebn/source/repos/Course-Work/test.json");
            string json = r.ReadToEnd();
            List<MovieEntity> movies = JsonConvert.DeserializeObject<List<MovieEntity>>(json);
            r.Close();
            if (movies == null)
            {
                List<MovieEntity> firstMovie = new List<MovieEntity>();
                firstMovie.Add(movie);
                File.AppendAllText("C:/Users/glebn/source/repos/Course-Work/test.json", JsonConvert.SerializeObject(firstMovie));
                return;
            }
            movies.Add(movie);
            File.AppendAllText("C:/Users/glebn/source/repos/Course-Work/test.json", JsonConvert.SerializeObject(movies));



            // File.WriteAllText("C:/Users/glebn/source/repos/Course-Work/test.json", String.Empty);


            //Console.WriteLine(JsonConvert.SerializeObject(movie));
        }

        public void DeleteMovieById(int Id)
        {

            StreamReader r = new StreamReader("C:/Users/glebn/source/repos/Course-Work/test.json");
            string json = r.ReadToEnd();
            List<MovieEntity> movies = JsonConvert.DeserializeObject<List<MovieEntity>>(json);
            movies.RemoveAt(Id - 1);
            r.Close();
            File.WriteAllText("C:/Users/glebn/source/repos/Course-Work/test.json", String.Empty);
            File.AppendAllText("C:/Users/glebn/source/repos/Course-Work/test.json", JsonConvert.SerializeObject(movies));

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
