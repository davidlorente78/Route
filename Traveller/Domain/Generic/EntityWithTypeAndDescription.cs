namespace Domain.Generic
{
    public abstract class EntityWithTypeAndDescription : Entity<int>
    {
        protected EntityWithTypeAndDescription() { }
        public string EntityType { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
