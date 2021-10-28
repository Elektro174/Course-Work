using Data.Repositiries.Abstract;
using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mappers;

namespace Data.Repositiries
{
    internal class DirectorsRepository : IDirectorsRepository
    {
        public void AddDirector(DirectorEntity director)
        {
            File.WriteAllText("test.json", string.Empty);
            File.AppendAllText("test.json", JsonConvert.SerializeObject(director));
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
