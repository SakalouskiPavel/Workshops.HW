using System;
using Rocket.BL.Common.Models.User;

namespace Rocket.BL.Common.Services.User
{
    /// <summary>
    /// Представляет сервис для работы со статусом аккаунта
    /// аккаунта.
    /// </summary>
    public interface IUserAccountStatusService : IDisposable
    {
        /// <summary>
        /// Получает статус аккаунта пользователя с определенным идентификатором.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <returns>Статус аккаунта пользователя.</returns>
        AccountStatus GetUserAccountStatus(int userId);

        /// <summary>
        /// Задает статус аккаунта пользователя с определенным идентификатором.
        /// </summary>
        /// <param name="userId">Идентификатор пользователя.</param>
        /// <param name="accountStatus">Статус аккаунта пользователя.</param>
        void SetUserAccountStatus(int userId, AccountStatus accountStatus);
    }
}