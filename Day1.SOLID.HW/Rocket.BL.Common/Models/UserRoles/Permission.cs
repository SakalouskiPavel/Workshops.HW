using System.Collections.Generic;

namespace Rocket.BL.Common.Models.UserRoles
{
    public class Permission : BllEntity
    {
        /// <summary>
        /// description of permission
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// name of Value
        /// </summary>
        public string ValueName { get; set; }
    }
}