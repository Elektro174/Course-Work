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
            movie.SalesFees = 100000;
            movie.Awards = "Оскар";
            movie.Country = "США";
            movie.ReleaseYear = 1997;
            movie.Budget = 2000000;
            movie.DirectorFirstName = "Чак";
            movie.DirectorLastName = "Паланик";
            MoviesRepository repository = new MoviesRepository();
            MoviesService movieService = new MoviesService(repository);
            movieService.AddMovie(movie);
            movieService.AddMovie(movie);
            movieService.AddMovie(movie);
            movieService.AddMovie(movie);
            movieService.AddMovie(movie);
            movieService.AddMovie(movie);
            // movieService.DeleteMovieById(6);
            // Console.ReadKey();
        }
    }
}
