namespace Traveller.Domain
{
    public class Airport
    {
        public int AirportID { get; set; }
        public AirportType AirportType { get; set; }
        public string IATACode { get; set; }
        public string? ICAOCode { get; set; }
        public string Name { get; set; }
        public string? LocalName { get; set; }
        public virtual ICollection<Destination>? ServingDestinations { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }

        public Airport() {

            this.ServingDestinations = new HashSet<Destination>();
        }
    }

    public class AirportType
    {
        public int AirportTypeID { get; set; }
        public char? Code { get; set; }
        public string? Description { get; set; }


    }
}
