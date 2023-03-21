using Domain.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Routes
{
    public class Passport : Entity
    {
        public Nationality Nationality { get; set; }

        public string IDNumber  { get; set; }

        public string Name { get; set; }

        public string Surnames { get; set; }

        public List<VisaStamp>? VisaStamps { get; set; }

    }
}
