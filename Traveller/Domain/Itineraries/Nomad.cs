﻿using Domain.Generic;

namespace Domain.Itineraries
{
    public class Nomad : Entity<int>
    {
        public Passport Passport { get; set; }

        //Other Personal Data

        public string Name { get; set; }
        public string Surnames { get; set; }
    }
}
