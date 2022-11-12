using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;

namespace Domain
{
    public class Nationality
    {
        public int NationalityID { get; set; }     
        public string Code      { get; set; }
        public string? Description { get; set; }
        public ICollection<Visa> Visas { get; set; } = new List<Visa>();
    }
}
