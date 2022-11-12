using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generic
{
    public abstract class Entity
    {
        protected Entity() { }

        public int ID { get; set; }
    }
}
