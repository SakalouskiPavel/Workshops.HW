using System;
using Rocket.DAL.Common.Enums;

namespace Rocket.DAL.Common.DbModels.Notification
{
    /// <summary>
    /// Лог нотификации
    /// </summary>
    public class NotificationsLogEntity : Entity
    {
        /// <summary>
        /// Id релиза
        /// </summary>
        public int ReleaseId { get; set; }
    }
}
