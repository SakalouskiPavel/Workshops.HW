using System;

namespace Rocket.DAL.Common.DbModels
{
    public abstract class Entity
    {
        public int Id { get; set; }


        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}