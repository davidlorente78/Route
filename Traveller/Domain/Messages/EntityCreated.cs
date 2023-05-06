namespace Domain.Messages
{
    public class EntityCreated
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; init; }
    }
}
