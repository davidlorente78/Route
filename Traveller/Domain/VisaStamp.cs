namespace Traveller.Domain
{
    public class VisaStamp
    {
        public Visa Visa;
        public Country Country { get; set; }
        public BorderCrossing EntryPoint { get; set; }
        public BorderCrossing ExitPoint { get; set; }


        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }


        public DateTime EntryDate { get; set; }
        public DateTime ExitDate { get; set; }
       

        public DateTime ValidUntill { get; set; }
        public DateTime ValidFrom { get; set; }
    }
}
