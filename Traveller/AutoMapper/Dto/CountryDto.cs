namespace Traveller.Application.Dto
{
    public class CountryDto
    {
        public int CountryID { get; set; }
        public char Code { get; set; }
        public string Name { get; set; }
        public bool ShowInDynamicHome { get; set; }
        public int ShowInDynamicHomeOrder { get; set; }
    }
}
