using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generic
{
    public abstract class EntityWithNameAndDescription : Entity
    {
        protected EntityWithNameAndDescription() { }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
