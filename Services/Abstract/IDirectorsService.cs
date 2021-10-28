using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
