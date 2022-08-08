namespace Traveller.Domain
{
    public class Airline
    {
        public int AirlineID { get; set; }
        public AirlineType AirportType { get; set; }
        public string IATACode { get; set; }       
        public string Name { get; set; }
        public string? LocalName { get; set; }
        public int MainAirportID { get; set; }
        public virtual Airport MainAirport { get; set; }
        public string? Url { get; set; }
       
        public Airline() {

           
        }
    }

    public class AirlineType
    {
        public int AirlineTypeID { get; set; }
        public char? Code { get; set; }
        public string? Description { get; set; }


    }
}
