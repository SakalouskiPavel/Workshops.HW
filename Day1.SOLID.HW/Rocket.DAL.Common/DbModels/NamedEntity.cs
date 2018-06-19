namespace Rocket.DAL.Common.DbModels
{
    public abstract class NamedEntity : Entity
    {
        public string Name { get; set; }
    }
}