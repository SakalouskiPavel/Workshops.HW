using System;

namespace Rocket.BL.Common.Services.ReleaseList
{
    public interface ISubscriptionService : IDisposable
    {
        /// <summary>
        /// Desc of subscribe method.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="id"></param>
        void Subscribe(string userId, int id);

        /// <summary>
        /// Desc of unsubscribe method.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="id"></param>
        void Unsubscribe(string userId, int id);
    }
}
