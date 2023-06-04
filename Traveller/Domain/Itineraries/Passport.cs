using Domain.Generic;

namespace Domain.Itineraries
{
    public class Passport : Entity
    {
        public Nationality Nationality { get; set; }

        public string IDNumber { get; set; }

        public string Name { get; set; }

        public string Surnames { get; set; }

        public List<VisaStamp>? VisaStamps { get; set; }

    }
}
