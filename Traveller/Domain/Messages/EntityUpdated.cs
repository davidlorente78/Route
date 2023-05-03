namespace Domain.Messages
{
    public class EntityUpdated
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; init; }
    }
}
