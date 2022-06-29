using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;
using Traveller.StaticData;

namespace DataBaseInit
{
    public class StaticData
    {
        public StaticData() { }
        public void Insert() {

            using (CountryDbContext ctx = new CountryDbContext())
            {
                Country Laos = new Country
                {
                   
                    Code = 'L',
                    Name = "Laos",
                    //Frontiers = LaosFrontiers.Frontiers,
                    Destinations = new List<Destination> { LaosDestinations.LPQ, LaosDestinations.VTE, LaosDestinations.Savannakhet },
                    //Visas = new List<Visa> { LaosVisas.eLaoVisa, LaosVisas.LaoVisa }
                };


                ctx.Countries.Add(Laos);
                ctx.SaveChanges();
            }
        }
    }
}
