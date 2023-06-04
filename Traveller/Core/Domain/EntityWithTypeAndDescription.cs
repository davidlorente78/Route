using Core.Domain;

namespace Domain.Generic
{
    public abstract class EntityWithTypeAndDescription : Entity
    {
        protected EntityWithTypeAndDescription() { }
        public string EntityType { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
