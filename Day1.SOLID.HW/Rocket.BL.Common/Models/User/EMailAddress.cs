namespace Rocket.BL.Common.Models.User
{
    /// <summary>
    /// Представляет информацию о адресе электронной почты дополнительной информации пользователя.
    /// </summary>
    public class EmailAddress : BllEntity
    {
        /// <summary>
        /// Возвращает или задает содержание адресе электронной почты дополнительной информации пользователя.
        /// </summary>
        public string Address { get; set; }
    }
}