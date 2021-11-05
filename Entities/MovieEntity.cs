using Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class MovieEntity : BaseEntity
    {
        public string Title { get; set; }
        public string DirectorFirstName { get; set; }
        public string DirectorLastName { get; set; }
        public string Country { get; set; }
        public int ReleaseYear { get; set; }
        public int Budget { get; set; }
        public int SalesFees { get; set; }
        public string Awards { get; set; }
    }
}
