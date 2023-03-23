using System.ComponentModel.DataAnnotations;

namespace Traveller.Domain
{
    public class BorderCrossing
    {
        public int BorderCrossingID { get; set; }


        public BorderCrossing()
        {
            this.Visas = new HashSet<Visa>();
        }

        public int BorderCrossingCountryID { get; set; }
        public virtual Country BorderCrossingCountry { get; set; }


        public int? DestinationOriginID { get; set; }
        public virtual Destination  DestinationOrigin { get; set; }

        public int? DestinationFinalID { get; set; }
        public virtual Destination DestinationFinal { get; set; }

        public string Name { get; set; }
        public string? LocalName { get; set; }
        public string? Description { get; set; }

        [Display(Name = "Border Crossing Type")]
        public BorderCrossingType BorderCrossingType { get; set; }     

        public virtual ICollection<Visa>? Visas { get; set; }
     
        public override string ToString()
        {
            string summmary = "";

            summmary = summmary + Name + Environment.NewLine;
            summmary = summmary + Description + Environment.NewLine;
            summmary = summmary + "Accepted visas in this border : " + Environment.NewLine;

            //foreach (Visa visa in Visas)
            //{
            //    summmary = summmary + visa.Name;
            //}

            return summmary;
        }
    }

   

}
