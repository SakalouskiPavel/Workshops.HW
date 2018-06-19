namespace Rocket.DAL.Common.DbModels.DbPersonalArea
{
    /// <summary>
    /// Модель хранения данных e-mail.
    /// </summary>
    public class DbEmail : Entity
    {
        /// <summary>
        /// Имя Email-адреса.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Внешний ключ к таблице DbAuthorisedUser.
        /// </summary>
        public string DbUserProfileId { get; set; }

        /// <summary>
        /// Ссылка на DbAuthorisedUser.
        /// </summary>
        public virtual DbUserProfile DbUserProfile { get; set; }
    }
}