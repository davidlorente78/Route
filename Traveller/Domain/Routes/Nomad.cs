using Domain.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Routes
{
    public class Nomad : Entity
    {
        public Passport Passport { get; set; }

        //Other Personal Data

        public string Name { get; set; }
        public string Surnames { get; set; }
    }
}
