namespace Traveller.Domain
{
    public class Visa
    {

        public int VisaId { get; set; }
        public string Name;
        public char Country;
        public string Description;
        public string URL;


        public int Duration;
        public char Entries;
        public string Category;
        public int Validity;
        public DateTime RequestedDate;

        public bool Extensible;
        public int ExtensionDays;
        public int ExtensionFee;
        public bool OnLine;

        public char Currency;
        public int Fee;

        public List<Destination> ValidEntryPoints;

        public DateTime ValidUntill;
        public DateTime ValidFrom;




    }
}
