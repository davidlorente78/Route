﻿namespace Domain.Messages
{
    public class DestinationCreated
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DestinationTypeId { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; init; }
    }
}