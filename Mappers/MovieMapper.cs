using Domain;
using Entities;
using System;
using System.Collections.Generic;

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
                ReleaseYear = movie.ReleaseYear,
                SalesFees = movie.SalesFees,
                Title = movie.Title,
                DirectorFirstName = movie.DirectorFirstName,
                DirectorLastName = movie.DirectorLastName,
                CreatedDdate = movie.CreatedDdate,
                Id = movie.Id
            };
        }
        public static Movie ToDomain(this MovieEntity movie)
        {
            return new Movie
            {
                Awards = movie.Awards,
                Budget = movie.Budget,
                Country = movie.Country,
                ReleaseYear = movie.ReleaseYear,
                SalesFees = movie.SalesFees,
                Title = movie.Title,
                DirectorFirstName = movie.DirectorFirstName,
                DirectorLastName = movie.DirectorLastName,
                CreatedDdate = movie.CreatedDdate,
                Id = movie.Id
            };
        }
        public static List<Movie> ToDomainList(this List<MovieEntity> movies)
        {
            if (movies != null)
            {
                List<Movie> movie = movies.ConvertAll(new Converter<MovieEntity, Movie>(ToDomain));
                return movie;
            }
            return null;
        }
        public static List<MovieEntity> ToEntityList(this List<Movie> movies)
        {
            List<MovieEntity> movie = movies.ConvertAll(new Converter<Movie, MovieEntity>(ToEntity));
            return movie;
        }
    }
}