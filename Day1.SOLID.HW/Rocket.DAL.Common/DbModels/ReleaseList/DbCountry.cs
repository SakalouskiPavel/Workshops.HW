using System;
using System.Collections.Generic;
using Rocket.DAL.Common.DbModels.User;

namespace Rocket.DAL.Common.DbModels.ReleaseList
{
    /// <summary>
    /// Представляет модель хранения данных о странах
    /// </summary>
    public class DbCountry : NamedEntity
    {
        /// <summary>
        /// Возвращает или задает коллекцию детальной информации о пользователях,
        /// к которым относится данная страна.
        /// </summary>
        public virtual ICollection<DbUserDetail> DbUserDetails { get; set; }

        /// <summary>
        /// Возвращает или задает коллекцию адресов детальной информации пользователей,
        /// к которым относится данная страна.
        /// </summary>
        public virtual ICollection<DbAddress> DbAddresses { get; set; }
    }
}