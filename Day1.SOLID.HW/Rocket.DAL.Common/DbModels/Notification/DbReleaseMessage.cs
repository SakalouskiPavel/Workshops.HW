using System;
using System.Collections.Generic;
using Rocket.DAL.Common.DbModels.ReleaseList;
using Rocket.DAL.Common.Enums;

namespace Rocket.DAL.Common.DbModels.Notification
{
    /// <summary>
    /// Описывает модель хранения данных о сообщении о релизе
    /// </summary>
    public class DbReleaseMessage : Entity
    {
        /// <summary>
        /// Возвращает или задает идентификационный номер релиза
        /// из модели <see cref="DbBaseRelease"/>
        /// </summary>
        public int ReleaseId { get; set; }

        /// <summary>
        /// Возвращает или задает тип релиза (фильм,
        /// музыкальный релиз, серия сериала)
        /// </summary>
        public ReleaseType ReleaseType { get; set; }

        /// <summary>
        /// Возвращает или задает коллекцию объектов, содержащих 
        /// сводные данные о получателе и сообщении о релизе
        /// </summary>
        public virtual ICollection<DbReceiver> Receivers { get; set; }
        
        /// <summary>
        /// Возвращает или задает дату выхода релиза
        /// </summary>
        public DateTime ReleaseDate { get; set; }
    }
}
