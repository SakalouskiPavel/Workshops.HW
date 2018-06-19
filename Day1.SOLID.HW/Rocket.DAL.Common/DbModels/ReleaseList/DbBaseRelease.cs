using System;

namespace Rocket.DAL.Common.DbModels.ReleaseList
{
    /// <summary>
    /// Представляет базовый тип для моделей хранения релизов
    /// (фильмов, серий, музыкальных альбомов)
    /// </summary>
    public abstract class DbBaseRelease : Entity
    {
        /// <summary>
        /// Возвращает или задает дату выхода релиза
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Возвращает или задает название релиза
        /// </summary>
        public string Title { get; set; }
    }
}