namespace Rocket.BL.Common.Models.User
{
    /// <summary>
    /// Представляет информацию о статусе аккаунта пользователя
    /// (активирован, не активирован, забанен, деактивирован).
    /// </summary>
    public class AccountStatus : BllEntity
    {
        /// <summary>
        /// Возвращает или задает название статуса аккаунта
        /// (активирован, не активирован, деактивирован, забанен).
        /// </summary>
        public string Name { get; set; }
    }
}