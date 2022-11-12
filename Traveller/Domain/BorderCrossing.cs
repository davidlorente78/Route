using System.ComponentModel.DataAnnotations;

namespace Traveller.Domain
{
    public class BorderCrossing
    {
        /// <summary>
        /// 'Si especifica la restricción FOREIGN KEY 'FK_Frontier_Destination_OriginDestinationID' en la tabla 'Frontier', 
        /// podrían producirse ciclos o múltiples rutas en cascada. Especifique ON DELETE NO ACTION o UPDATE NO ACTION, 
        /// o bien modifique otras restricciones FOREIGN KEY.
        /// </summary>
        /// 

        public BorderCrossing()
        {

            this.Visas = new HashSet<Visa>();

        }
        public int BorderCrossingID { get; set; }

        public int OriginID { get; set; }

        public virtual Destination Origin { get; set; }

        public int FinalID { get; set; }

        public virtual Destination Final { get; set; }

        public string Name { get; set; }
        public string? Description { get; set; }
        [Display(Name = "Frontier Type")]
        public BorderCrossingType FrontierType { get; set; }     

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
