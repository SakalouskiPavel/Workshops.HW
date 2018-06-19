using System;
using Rocket.BL.Common.Models.User;

namespace Rocket.BL.Common.Services.User
{
    /// <summary>
    /// Представляет сервис для работы с уровнем пользователя (обычный, премиум).
    /// </summary>
    public interface IUserAccountLevelService : IDisposable
    {
        /// <summary>
        /// Получает уровень аккаунта пользователя с заданным идентификатором.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <returns>Уровень аккаунта пользователя.</returns>
        AccountLevel GetUserAccountLevel(int userId);

        /// <summary>
        /// Задает значение уровня аккаунта пользователя с заданным идентификатором.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <param name="accountLevel">Задаваемый уровень аккаунта.</param>
        void SetUserAccountLevel(int userId, AccountLevel accountLevel);
    }
}