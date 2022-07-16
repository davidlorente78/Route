namespace Domain
{
    public class Line
    {
        public int LineID { get; set; }
        public char LineType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Station> MainTrunk { get; set; }
        public ICollection<Line>? BranchLines { get; set; }       


    }



}
