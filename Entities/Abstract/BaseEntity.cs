using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Abstract
{
    public abstract class BaseEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDdate { get; set; }
    }
}
