namespace Traveller.Application.Dto
{
    public class CountryDto : Dto
    {
        public char Code { get; set; }
        public string Name { get; set; }
        public bool ShowInDynamicHome { get; set; }
        public int ShowInDynamicHomeOrder { get; set; }
    }
}
