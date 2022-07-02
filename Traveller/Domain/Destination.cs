using System.ComponentModel.DataAnnotations.Schema;

namespace Traveller.Domain
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public char CountryCode { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public char Type { get; set; }

        //Añadida a posteriori para acceder desde CountryViewIndex
        [NotMapped]
        public int CountryID { get; set; }
    }
}
