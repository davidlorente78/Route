namespace Traveller.Domain
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public char CountryCode { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DestinationType? DestinationType { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
    }

    public class DestinationType
    {
        public int DestinationTypeID { get; set; }
        public char? Code { get; set; }      
        public string? Description { get; set; }
        
    }
}
