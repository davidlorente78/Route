namespace Traveller.Domain
{
    public class Country
    {

        //Se debe añadir get set para que ser interpretado correctamente como columna en la tabla
        //De forma predeterminada, EF interpreta como la clave principal una propiedad que se denomine ID o classnameID.Por ejemplo, la clave principal podría tener el nombre StudentID en lugar de ID.

        public int CountryID { get; set; }
        public char Code { get; set; }
        public string Name { get; set; }

        public ICollection<Destination> Destinations { get; set; }
        public ICollection<Frontier> Frontiers { get; set; }        

        //public ICollection<Visa> Visas { get; set; }

        public Country() { }


    }
}
