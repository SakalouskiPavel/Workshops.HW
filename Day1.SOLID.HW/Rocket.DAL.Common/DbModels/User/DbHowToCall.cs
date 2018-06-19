using System.Collections.Generic;

namespace Rocket.DAL.Common.DbModels.User
{
    /// <summary>
    /// Представляет модель хранения сведений о том, как обращаться к пользователю.
    /// </summary>
    public class DbHowToCall : Entity
    {
        /// <summary>
        /// Возвращает или задает обращение к пользователю.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Задает или возвращает коллекцию дополнительной информации пользователя,
        /// к которой относится это сведение о том, как обращаться к пользователю.
        /// </summary>
        public virtual ICollection<DbUserDetail> DbUserDetails { get; set; }
    }
}