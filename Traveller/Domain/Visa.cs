namespace Traveller.Domain
{
    public class Visa
    {

        public int VisaID { get; set; }
        public string Name { get; set; }
        public char Country { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }


        public int Duration { get; set; }
        public char Entries { get; set; }
        public string Category { get; set; }
        public int Validity { get; set; }
        public DateTime RequestedDate { get; set; }

        public bool Extensible { get; set; }
        public int ExtensionDays { get; set; }
        public int ExtensionFee { get; set; }
        public bool OnLine { get; set; }

        public char Currency { get; set; }
        public int Fee { get; set; }

        public ICollection<Destination> ValidEntryPoints { get; set; }

      



    }
}
