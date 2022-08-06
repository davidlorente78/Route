
using Domain;
using Domain.Ranges;
/// <summary>
/// Domain – Holds the Entities and Interfaces. It does not depend on any other project in the solution.
/// </summary>
namespace Traveller.Domain
{
    public class Country
    {
        //Se debe añadir get set para que ser interpretado correctamente como columna en la tabla
        //De forma predeterminada, EF interpreta como la clave principal una propiedad que se denomine ID o classnameID.
        //Por ejemplo, la clave principal podría tener el nombre CountryID en lugar de ID.

        public int CountryID { get; set; }
        public char Code { get; set; }
        public string Name { get; set; }

        public bool ShowInDynamicHome { get; set; }

        public int ShowInDynamicHomeOrder { get; set; }

        /// <summary>
        /// Virtual ensures that ...
        /// </summary>
        public virtual ICollection<Destination>? Destinations { get; set; }
        public virtual ICollection<Frontier>? Frontiers { get; set; }      
        public ICollection<Visa>? Visas { get; set; }
        public ICollection<Line>? TrainLines { get; set; }
        public ICollection<RangeChar>? Ranges { get; set; }
        public ICollection<Airport>? Airports { get; set; }

        public Country() { }


    }
}
