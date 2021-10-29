using Domain;

namespace Services.Abstract
{
    public interface IDirectorsService
    {
        void AddDirector(Director director);
        void UpdateDriver(Director director);
        Director GetDirectorById(int id);
        void DeleteDirectorById(int Id);
    }
}
