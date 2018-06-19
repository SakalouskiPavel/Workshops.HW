using System.Collections.Generic;

namespace Rocket.DAL.Common.DbModels.User
{
    /// <summary>
    /// Представляет модель хранения данных о языке дополнительной информации пользователя.
    /// </summary>
    public class DbLanguage : NamedEntity
    {
        /// <summary>
        /// Задает или возвращает коллекцию дополнительной информации пользователя,
        /// к которой относится этот язык.
        /// </summary>
        public virtual ICollection<DbUserDetail> DbUserDetails { get; set; }
    }
}