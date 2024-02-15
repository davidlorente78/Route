using Domain.Generic;
using Domain.Ranges;
using Domain.Transport.Aviation;
using Domain.Transport.Railway;

/// <summary>
/// Domain – Holds the Entities and Interfaces. It does not depend on any other project in the solution.
/// </summary>
namespace Traveller.Domain
{

    public class Country : Entity<int>
    {
        //Se debe añadir get set para que ser interpretado correctamente como columna en la tabla
        //De forma predeterminada, EF interpreta como la clave principal una propiedad que se denomine ID o classnameID.
        //Por ejemplo, la clave principal puede tener el nombre CountryID en lugar de ID.
        public char Code { get; private set; }
        public string Name { get; private set; }
        public string? Image { get; set; }
        public bool ShowInDynamicHome { get; private set; }
        public int ShowInDynamicHomeOrder { get; private set; }
        public virtual ICollection<Destination> Destinations { get; set; }
        public virtual ICollection<BorderCrossing> BorderCrossings { get; set; }
        public virtual ICollection<Visa> Visas { get; set; }
        public virtual ICollection<RailwayLine> TrainLines { get; set; }
        public virtual ICollection<RangeChar> Ranges { get; set; }
        public virtual ICollection<Airport> Airports { get; set; }

        //public int? RailwaySystemId { get; set; }
        //public RailwaySystem? RailwaySystem { get; set; }

        public Country() { }

        public Country(char code, string name, DynamicHomeConfiguration showInHome)
        {
            SetCode(code);
            SetName(name);
            ShowInDynamicHome = showInHome.Show;
            ShowInDynamicHomeOrder = showInHome.Order;

            Destinations = new List<Destination>();
            BorderCrossings = new List<BorderCrossing>();
            Visas = new List<Visa>();
            TrainLines = new List<RailwayLine>();
            Ranges = new List<RangeChar>();
            Airports = new List<Airport>();
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre del país no puede estar vacío o ser nulo");

            Name = name;
        }

        public void SetCode(char code)
        {
            if (code == ' ')
                throw new ArgumentException("El código del país no puede estar vacío o ser nulo");

            Code = code;
        }

        public void AddDestination(Destination destination)
        {
            if (!Destinations.Contains(destination))
            {
                Destinations.Add(destination);
                destination.Country = this;
            }
        }

        public void RemoveDestination(Destination destination)
        {
            if (Destinations.Contains(destination))
            {
                Destinations.Remove(destination);
            }
        }
    }
}
