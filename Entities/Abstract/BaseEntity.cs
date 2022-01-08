using System.ComponentModel.DataAnnotations;

namespace Entities.Abstract
{
    public abstract class BaseEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string CreatedDdate { get; set; }
    }
}