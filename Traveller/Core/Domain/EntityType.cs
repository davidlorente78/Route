using Core.Domain;

namespace Domain.Generic
{
    public class EntityType : Entity
    {
        public char? Code { get; set; }
        public string? Description { get; set; }
    }
}
