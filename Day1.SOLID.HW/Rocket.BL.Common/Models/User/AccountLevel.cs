namespace Rocket.BL.Common.Models.User
{
    /// <summary>
    /// Представляет информацию об уровне пользователя: обыкнованный, премиум
    /// и типе аккауинта.
    /// </summary>
    public class AccountLevel : BllEntity
    {
        /// <summary>
        /// Возвращает или задает название уровня пользователя.
        /// </summary>
        public string Name { get; set; }
    }
}