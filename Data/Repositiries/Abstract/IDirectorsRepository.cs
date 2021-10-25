using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
