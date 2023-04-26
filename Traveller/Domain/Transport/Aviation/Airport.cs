using Domain.Generic;
using System.ComponentModel.DataAnnotations;
using Traveller.Domain;

namespace Domain.Transport.Aviation
{
    public class Airport : Entity
    {
        [Required]
        [Display(Name = "Airport Type")]
        public AirportType AirportType { get; set; }
        public int AirportTypeId { get; set; }
        public virtual Country AirportCountry { get; set; }
        public int AirportCountryId { get; set; }

        [Display(Name = "IATA Code")]
        public string IATACode { get; set; }
        [Display(Name = "ICAO Code")]
        public string? ICAOCode { get; set; }
        public string Name { get; set; }
        [Display(Name = "Local Name")]
        public string? LocalName { get; set; }
        public string? Description { get;  set; } //TODO Pero las variables de inicializacion estan definidas como static
        public virtual ICollection<Destination>? Destinations { get; set; }

        //TODO
        public Airport() { }

        public Airport(string name, string IATACode , AirportType airportType)
        {
            SetName(name);
            SetIATACode(IATACode);
            SetAirportType(airportType);
            Destinations = new HashSet<Destination>();
        }

        public Airport SetName(string name)
        {
            Name = name;

            return this;
        }

        public Airport SetIATACode(string iATACode)
        {
            IATACode = iATACode;

            return this;
        }

        public Airport SetAirportType(AirportType airportType)
        {
            AirportType = airportType;
            AirportTypeId = airportType.Id;

            return this;
        }

        public void UpdateLocalName(string localName)
        {
            LocalName = localName;
        }

        public void UpdateDescription(string description)
        {
            Description = description;
        }
    }
}
