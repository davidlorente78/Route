namespace Traveller.Domain
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public int CountryID { get; set; }
        public char CountryCode { get; set; }
        public string Name { get; set; }
        public int Days { get; set; }
        public string? Description { get; set; }

        public char Type { get; set; }
    }
}
