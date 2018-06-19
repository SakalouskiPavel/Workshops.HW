using System.Collections.Generic;

namespace Rocket.DAL.Common.DbModels.User
{
    /// <summary>
    /// Представляет модель хранения данных о статусе аккаунта.
    /// </summary>
    public class DbAccountStatus : NamedEntity
    {
        /// <summary>
        /// Возвращает или задает коллекцию пользователей,
        /// в которых указан данный статус пользователя.
        /// </summary>
        /// <value>Коллекция пользователей, в которых указан данный статус пользователя.</value>>
        public virtual ICollection<DbUser> DbUsers { get; set; }
    }
}