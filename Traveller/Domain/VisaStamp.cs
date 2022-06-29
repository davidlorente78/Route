namespace Traveller.Domain
{
    public class VisaStamp
    {
        public Visa Visa;
        public Country Country { get; set; }
        public Frontier EntryPoint { get; set; }
        public Frontier ExitPoint { get; set; }


        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }


        public DateTime EntryDate { get; set; }
        public DateTime ExitDate { get; set; }
       

        public DateTime ValidUntill { get; set; }
        public DateTime ValidFrom { get; set; }
    }
}
