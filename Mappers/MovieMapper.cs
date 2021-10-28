using Domain;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
{
    public static class MovieMapper
    {
        public static MovieEntity ToEntity(this Movie movie)
        {
            return new MovieEntity
            {
                Awards = movie.Awards,
                Budget = movie.Budget,
                Country = movie.Country,
                DirectorId = movie.DirectorId,
                ReleaseYear = movie.ReleaseYear,
                SalesFees = movie.SalesFees,
                Title = movie.Title
            };
        }
    }
}
