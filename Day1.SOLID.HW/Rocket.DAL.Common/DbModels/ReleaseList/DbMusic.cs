using System;
using System.Collections.Generic;
using Rocket.DAL.Common.DbModels.Parser;
using Rocket.DAL.Common.DbModels.Subscription;

namespace Rocket.DAL.Common.DbModels.ReleaseList
{
    /// <summary>
    /// Представляет модель хранения данных музыкального релиза
    /// </summary>
    public class DbMusic : SubscribableEntity
    {
        /// <summary>
        /// Возвращает или задает название музыкального релиза
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает или задает дату выхода музыкального релиза
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Возвращает или задает относительный путь
        /// от корневой папки приложения к файлу изображения постера музыкального релиза
        /// </summary>
        public string PosterImagePath { get; set; }

        /// <summary>
        /// Url постера на сайте ресурса
        /// </summary>
        public string PosterImageUrl { get; set; }

        /// <summary>
        /// Возвращает или задает продолжительность музыкального релиза
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Возвращает или задает коллекцию жанров, к которым относится музыкальный релиз
        /// </summary>
        public virtual ICollection<DbMusicGenre> Genres { get; set; }

        /// <summary>
        /// Возвращает или задает музыкальные треки которые относятся к релизу
        /// </summary>
        public virtual ICollection<DbMusicTrack> MusicTracks { get; set; }

        /// <summary>
        /// Возвращает или задает исполнителей музыкального релиза
        /// </summary>
        public virtual ICollection<DbMusician> Musicians { get; set; }

        /// <summary>
        /// Исполнитель
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Тип релиза
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Источники релиза
        /// </summary>
        public virtual ICollection<ResourceItemEntity> ResourceItems { get; set; }
    }
}
