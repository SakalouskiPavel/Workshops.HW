using System.Collections.Generic;

namespace Rocket.DAL.Common.DbModels.User
{
    /// <summary>
    /// Представляет модель хранения пола дополнительной информации пользователя.
    /// </summary>
    public class DbGender : NamedEntity
    {
        /// <summary>
        /// Задает или возвращает коллекцию дополнительной информации пользователя,
        /// к которой относится этот пол.
        /// </summary>
        public virtual ICollection<DbUserDetail> DbUserDetails { get; set; }
    }
}