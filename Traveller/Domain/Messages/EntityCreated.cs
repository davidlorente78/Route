namespace Domain.Messages
{
    public class EntityCreated
    {
        public string Type { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; init; }
    }
}
