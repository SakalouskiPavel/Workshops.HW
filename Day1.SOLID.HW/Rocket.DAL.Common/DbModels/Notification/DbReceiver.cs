using System.Collections.Generic;
using Rocket.DAL.Common.DbModels.DbPersonalArea;

namespace Rocket.DAL.Common.DbModels.Notification
{
    /// <summary>
    /// Описывает модель хранения данных о пользователе,
    /// являющемся получателем сообщения
    /// </summary>
    public class DbReceiver : Entity
    {
        /// <summary>
        /// Возвращает или задает флаг подписки на email нотификацию
        /// </summary>
        public bool NotifyByEmail { get; set; }

        /// <summary>
        /// Возвращает или задает флаг подписки на push нотификацию
        /// </summary>
        public bool NotifyByPush { get; set; }

        /// <summary>
        /// Возвращает или задает коллекцию сообщений о платежах,
        /// получателем которых является пользователь
        /// </summary>
        public virtual ICollection<DbUserBillingMessage> UserBillingMessages { get; set; }

        /// <summary>
        /// Возвращает или задает коллекцию сообщений произвольного содержания,
        /// получателем которых является пользователь
        /// </summary>
        public virtual ICollection<DbCustomMessage> CustomMessages { get; set; }

        /// <summary>
        /// Возвращает или задает коллекцию объектов, содержащих 
        /// сводные данные о получателе и сообщении о релизе
        /// </summary>
        public virtual ICollection<DbReleaseMessage> Releases { get; set; }
    }
}