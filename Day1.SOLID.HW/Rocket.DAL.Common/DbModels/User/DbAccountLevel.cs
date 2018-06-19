using System.Collections.Generic;

namespace Rocket.DAL.Common.DbModels.User
{
    /// <summary>
    /// Представляет модель хранения данных об уровне аккаунта пользователя.
    /// </summary>
    public class DbAccountLevel : NamedEntity
    {
        /// <summary>
        /// Возвращает или задает коллекцию пользователей,
        /// в которых указан данный уровень пользователя.
        /// </summary>
        /// <value>Коллекция пользователей с данным уровнем аккаунта пользователя.</value>>
        public virtual ICollection<DbUser> DbUsers { get; set; }
    }
}