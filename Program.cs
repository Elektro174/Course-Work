using Data.Repositiries.Abstract;
using Domain;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            director.FirstName = "Ivan";
            director.SecondName = "Ivanov";
            DirectorsService directorsService = new DirectorsService(director);
            directorsService.AddDirector(director);
        }
    }
}
