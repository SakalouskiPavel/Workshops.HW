namespace Rocket.BL.Common.Models.ReleaseList
{
    /// <summary>
    /// Представляет информацию о стране
    /// </summary>
    public class Country : BllEntity
    {
        /// <summary>
        /// Возвращает или задает название страны
        /// </summary>
        public string Name { get; set; }
    }
}