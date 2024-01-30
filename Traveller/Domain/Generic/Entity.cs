namespace Domain.Generic
{
    public abstract class Entity<T>
    {
        protected Entity() { }
        public T Id { get; set; }
    }
}
