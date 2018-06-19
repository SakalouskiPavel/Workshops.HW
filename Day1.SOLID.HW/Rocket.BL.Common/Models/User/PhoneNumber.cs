namespace Rocket.BL.Common.Models.User
{
    /// <summary>
    /// Представляет информацию о телефонном номере дополнительной информации пользователя.
    /// </summary>
    public class PhoneNumber : BllEntity
    {
        /// <summary>
        /// Возвращает или задает содержание телефонного номера дополнительной информации пользователя.
        /// </summary>
        public string Number { get; set; }
    }
}