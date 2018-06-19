using System;

namespace Rocket.DAL.Common.DbModels.Notification
{
    /// <summary>
    /// Описывает модель хранения данных сообщения с информацией о совершенных
    /// пользователем платежах на сайте (покупка премиум аккаунта, донат)
    /// </summary>
    public class DbUserBillingMessage : Entity
    {
        /// <summary>
        /// Возвращает или задает пользователя - получателя сообщения
        /// </summary>
        public virtual DbReceiver Receiver { get; set; }

        /// <summary>
        /// Возвращает или задает оплаченную сумму
        /// </summary>
        public decimal Sum { get; set; }

        /// <summary>
        /// Возвращает или задает флаг просмотра пользователем
        /// push нотификации
        /// </summary>
        public bool Viewed { get; set; }
    }
}