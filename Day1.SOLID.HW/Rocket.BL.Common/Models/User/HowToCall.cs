namespace Rocket.BL.Common.Models.User
{
    /// <summary>
    /// Представляет сведения о том, как обращаться к пользователю
    /// (Mr, Miss, Ms).
    /// </summary>
    public class HowToCall : BllEntity
    {
        /// <summary>
        /// Возвращает или задает обращение к пользователю.
        /// </summary>
        public string Name { get; set; }
    }
}