using Entities;

namespace Data.Repositiries.Abstract
{
    public interface IDirectorsRepository
    {
        void AddDirector(DirectorEntity director);
        void UpdateDriver(DirectorEntity director);
        DirectorEntity GetDirectorById(int id);
        void DeleteDirectorById(int Id);
    }
}
