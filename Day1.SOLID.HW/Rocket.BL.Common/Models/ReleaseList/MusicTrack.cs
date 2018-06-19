using System;

namespace Rocket.BL.Common.Models.ReleaseList
{
    public class MusicTrack : BllEntity
    {
        /// <summary>
        /// Возвращает или задает название музыкального трека
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает или задает продолжительность музыкального трека
        /// </summary>
        public TimeSpan Duration { get; set; }
    }
}