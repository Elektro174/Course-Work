using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MovieEntity : BaseEntity
    {
        public string Title { get; set; }
        public int DirectorId { get; set; }
        [ForeignKey("DirectorId")]
        public virtual DirectorEntity Director { get; set; }
        public string Country { get; set; }
        public int ReleaseYear { get; set; }
        public int Budget { get; set; }
        public int SalesFees { get; set; }
        public string Awards { get; set; }

    }
}
