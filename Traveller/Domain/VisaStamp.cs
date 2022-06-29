namespace Traveller.Domain
{
    public class VisaStamp
    {
        public Visa Visa;
        public Country Country;


        public DateTime IssueDate;
        public DateTime ExpiryDate;


        public DateTime EntryDate;
        public DateTime ExitDate;
        public Frontier EntryPoint;
        public Frontier ExitPoint;


    }
}
