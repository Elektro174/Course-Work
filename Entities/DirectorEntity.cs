using Entities.Abstract;

namespace Entities
{
    public class DirectorEntity : BaseEntity
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string SecondName { get; set; }
    }
}
