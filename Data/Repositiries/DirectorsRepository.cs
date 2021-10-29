using Data.Repositiries.Abstract;
using Entities;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Data.Repositiries
{
    public class DirectorsRepository : IDirectorsRepository
    {
        public void AddDirector(DirectorEntity director)
        {
           // File.WriteAllText("test.json", string.Empty);
            File.AppendAllText("C:/Users/glebn/source/repos/Course-Work/test.json", JsonConvert.SerializeObject(director));
        }

        public void DeleteDirectorById(int Id)
        {
            throw new NotImplementedException();
        }

        public DirectorEntity GetDirectorById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateDriver(DirectorEntity director)
        {
            throw new NotImplementedException();
        }
    }
}
