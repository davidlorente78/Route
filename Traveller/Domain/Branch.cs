using Traveller.Domain;

namespace Domain
{

    public class Branch
    {
        public int BranchID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public bool MainBranch { get; set; }


        public ICollection<Station> Stations { get; set; }


    }



}
