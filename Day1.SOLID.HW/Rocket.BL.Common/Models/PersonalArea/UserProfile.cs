using System.Collections.Generic;

namespace Rocket.BL.Common.Models.PersonalArea
{
    public class UserProfile : BllEntity
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия пользователя.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Относительный путь к аватаре пользователя.
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// Коллекция e-mail адресов пользователя.
        /// </summary>
        public virtual ICollection<Email> Emails { get; set; }

        /// <summary>
        /// Персональный список релизов в виде списка жанров TV. 
        /// </summary>
        public virtual ICollection<Genre> Genres { get; set; }

        /// <summary>
        /// Персональный список релизов в виде списка музыкальных жанров. 
        /// </summary>
        public virtual ICollection<MusicGenre> MusicGenre { get; set; }
    }
}