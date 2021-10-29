using Data.Repositiries;
using Domain;
using Services;
using System;

namespace Course_Work
{
    public class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie();
            movie.Title = "Бойцовский клуб";
            Director director = new Director();
            director.FirstName = "Чак";
            director.SecondName = "Паланик";
            movie.Director = director;
            movie.Director.FirstName = director.FirstName;
            movie.Director.SecondName = director.SecondName;
            movie.SalesFees = 100000;
            movie.Awards = "Оскар";
            movie.Country = "США";
            movie.ReleaseYear = 1997;
            movie.Budget = 2000000;
            movie.DirectorId = 1;
            MoviesRepository repository = new MoviesRepository();
            MoviesService directorService = new MoviesService(repository);
            directorService.AddMovie(movie);
            Console.ReadKey();
        }
    }
}
