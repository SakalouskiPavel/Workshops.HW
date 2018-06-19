using System;

namespace Rocket.BL.Common.Models.ReleaseList
{
    /// <summary>
    /// Представляет базовый тип для доменных моделей релизов
    /// (фильмов, серий, музыкальных альбомов)
    /// </summary>
    public abstract class BaseRelease : BllEntity
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