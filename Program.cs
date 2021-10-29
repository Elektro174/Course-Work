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
            Director director = new Director();
            director.FirstName = "Ivan";
            director.SecondName = "Ivanov";
            DirectorsRepository repository = new DirectorsRepository();
            DirectorsService directorService = new DirectorsService(repository);
            directorService.AddDirector(director);
            Console.ReadKey();
        }
    }
}
