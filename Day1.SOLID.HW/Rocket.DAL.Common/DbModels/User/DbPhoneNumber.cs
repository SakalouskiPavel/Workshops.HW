using System.Collections.Generic;

namespace Rocket.DAL.Common.DbModels.User
{
    /// <summary>
    /// Представляет модель хранения данных о телефонных номерах дополнительной информации пользователя.
    /// </summary>
    public class DbPhoneNumber : Entity
    {
        /// <summary>
        /// Задает или возвращает телефонный номер дополнительной информации пользователя.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Задает или возвращает коллекцию дополнительной информации пользователя,
        /// к которой относится этот телефонный номер.
        /// </summary>
        public virtual ICollection<DbUserDetail> DbUserDetails { get; set; }
    }
}