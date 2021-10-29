using System.Collections.Generic;

namespace Domain
{
    public class Director
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string SecondName { get; set; }
        public List<Movie> movies { get; set; }
    }
}
