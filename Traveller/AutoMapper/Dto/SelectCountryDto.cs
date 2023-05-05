namespace Traveller.Application.Dto
{
    public class SelectCountryDto
    {
        public int CountryID { get; set; }
        public char Code { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }
    }
}
