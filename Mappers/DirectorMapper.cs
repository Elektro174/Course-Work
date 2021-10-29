using Domain;
using Entities;
namespace Mappers
{
    public static class DirectorMapper
    {
        public static DirectorEntity ToEntity(this Director director)
        {
            return new DirectorEntity
            {
                FirstName = director.FirstName,
                SecondName = director.SecondName
            };
        }
        public static Director ToDomain(this DirectorEntity director)
        {
            return new Director
            {
                FirstName = director.FirstName,
                SecondName = director.SecondName
            };
        }
    }
}
