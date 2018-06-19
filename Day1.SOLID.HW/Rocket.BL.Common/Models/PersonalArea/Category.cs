using System.Collections.Generic;

namespace Rocket.BL.Common.Models.PersonalArea
{
    /// <summary>
    /// Класс, содержащий данные о категории (фильм, сериал или музыка).
    /// </summary>
    public class Category : BllEntity
    {
        /// <summary>
        /// Имя категории.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список жанров данной категории.
        /// </summary>
        public virtual ICollection<Genre> Genres { get; set; }
    }
}