using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Rocket.BL.Common.Models.Subscription
{
    /// <summary>
    /// Представляет базовую модель ресурсов, на которые возможна подписка
    /// </summary>
    public abstract class Subscribable : BllEntity
    {
        /// <summary>
        /// Коллекция пользователей подписанных на данный ресурс
        /// </summary>
        public virtual ICollection<User.User> Users { get; set; } = new Collection<User.User>();
    }
}
