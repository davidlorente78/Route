namespace Traveller.Domain
{
    public class Frontier
    {
        public int FrontierID;
        public Destination Origin { get; set; }
        public Destination Destination { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Visa> Visas { get; set; }
        public string Type { get; set; } //T A

        public bool Transit { get; set; }
        public string Transport { get; set; }
        public Destination TransitOrigin { get; set; }
        public Destination TransitDestination { get; set; }

        public override string ToString()
        {
            string summmary = "";

            summmary = summmary + Name + Environment.NewLine;
            summmary = summmary + Description + Environment.NewLine;


            summmary = summmary + "Accepted visas in this border : " + Environment.NewLine;
            foreach (Visa visa in Visas)
            {
                summmary = summmary + visa.Name;
            }

            return summmary;
        }
    }
}
