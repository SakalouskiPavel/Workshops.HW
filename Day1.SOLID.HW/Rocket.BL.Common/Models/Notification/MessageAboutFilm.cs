using System;

namespace Rocket.BL.Common.Models.Notification
{
    /// <summary>
    /// Описывает сообщение о релизе фильма
    /// </summary>
    public class MessageAboutFilm
    {
        /// <summary>
        /// Возвращает или задает получателя сообщения
        /// </summary>
        public  virtual Receiver Receiver { get; set; }

        /// <summary>
        /// Возвращает или задает релиз фильма для целей нотификации 
        /// </summary>
        public virtual FilmForNotification Film { get; set; }

        /// <summary>
        /// Возвращает или задает время создания сообщения
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}