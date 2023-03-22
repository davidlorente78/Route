using Domain.Generic;
using Domain.Ranges;
using Domain.Transport.Aviation;
using Domain.Transport.Railway;

/// <summary>
/// Domain – Holds the Entities and Interfaces. It does not depend on any other project in the solution.
/// </summary>
namespace Traveller.Domain
{
    public class Country : Entity
    {
        //Se debe añadir get set para que ser interpretado correctamente como columna en la tabla
        //De forma predeterminada, EF interpreta como la clave principal una propiedad que se denomine ID o classnameID.
        //Por ejemplo, la clave principal puede tener el nombre CountryID en lugar de ID.
        public char Code { get; set; }
        public string Name { get; set; }
        public bool ShowInDynamicHome { get; set; }
        public int ShowInDynamicHomeOrder { get; set; }

        public virtual ICollection<Destination> Destinations { get; set; } = new List<Destination>();
        public virtual ICollection<BorderCrossing> BorderCrossings { get; set; } = new List<BorderCrossing>();

        //public virtual ICollection<Visa> Visas { get; set; } = new List<Visa>();
        public virtual ICollection<RailwayLine> TrainLines { get; set; } = new List<RailwayLine>();
        public virtual ICollection<RangeChar> Ranges { get; set; } = new List<RangeChar>();
        public virtual ICollection<Airport> Airports { get; set; } = new List<Airport>();

        public Country() { }

        public Country(char code, string name, bool showInDynamicHome, int showInDynamicHomeOrder)
        {
            Code = code;
            Name = name;
            ShowInDynamicHome = showInDynamicHome;
            ShowInDynamicHomeOrder = showInDynamicHomeOrder;

            //TODO Inicializar listas aqui
        }


    }
}
