namespace Rocket.BL.Common.Models.User
{
    /// <summary>
    /// Представляет пол пользователя.
    /// (Mr, Miss, Ms).
    /// </summary>
    public class Gender : BllEntity
    {
        /// <summary>
        /// Возвращает или задает пол пользователя.
        /// </summary>
        public string Name { get; set; }
    }
}