using System;
using System.Collections.Generic;
using Rocket.BL.Common.Models.ReleaseList;

namespace Rocket.BL.Common.Models.User
{
    /// <summary>
    /// Детальная информация о пользователе.
    /// </summary>
    public class UserDetail : BllEntity
    {
        /// <summary>
        /// Возвращает или задает необходимость подтверждения регистрации
        /// путем активации Email.
        /// </summary>
        public bool ActivationNeeded { get; set; }

        /// <summary>
        /// Задает или возвращает гражданство пользователя.
        /// </summary>
        public virtual Country Sitizenship { get; set; }

        /// <summary>
        /// Задает или возвращает язык пользователя.
        /// </summary>
        public virtual Language Language { get; set; }

        /// <summary>
        /// Задает или возвращает дату рождения пользователя.
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Задает или возвращает пол пользователя.
        /// </summary>
        public virtual Gender Gender { get; set; }

        /// <summary>
        /// Задает или возвращает сведения о том, как обращаться к пользователю.
        /// </summary>
        public virtual HowToCall HowToCall { get; set; }

        /// <summary>
        /// Задает или возвращает коллекцию телефонных номеров пользователя.
        /// </summary>
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// Задает или возвращает коллекцию Email.
        /// </summary>
        public virtual ICollection<EmailAddress> EMailAddresses { get; set; }

        /// <summary>
        /// Возвращает или задает почтовый адрес пользователя.
        /// </summary>
        public virtual Address MailAddress { get; set; }
    }
}