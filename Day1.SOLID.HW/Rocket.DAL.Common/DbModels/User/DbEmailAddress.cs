using System.Collections.Generic;

namespace Rocket.DAL.Common.DbModels.User
{
    /// <summary>
    /// Представляет модель хранения данных о адресах электронной почты дополнительной информации пользователя.
    /// </summary>
    public class DbEmailAddress : Entity
    {
        /// <summary>
        /// Задает или возвращает адреса электронной почты дополнительной информации пользователя.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Задает или возвращает коллекцию дополнительной информации пользователя,
        /// к которой относится этот адрес электронной почты.
        /// </summary>
        public virtual ICollection<DbUserDetail> DbUserDetails { get; set; }
    }
}