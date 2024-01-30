namespace Domain.Generic
{
    public class EntityType : Entity<int>
    {
        public char? Code { get; set; }
        public string? Description { get; set; }
    }
}
