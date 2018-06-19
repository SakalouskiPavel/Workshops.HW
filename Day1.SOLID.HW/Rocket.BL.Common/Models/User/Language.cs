namespace Rocket.BL.Common.Models.User
{
    /// <summary>
    /// Представляет сведения о языке.
    /// </summary>
    public class Language : BllEntity
    {
        /// <summary>
        /// Задает или возвращает название языка пользователя.
        /// </summary>
        public string Name { get; set; }
    }
}