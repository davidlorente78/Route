using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Generic
{
    public abstract class EntityWithTypeAndDescription : Entity
    {
        protected EntityWithTypeAndDescription() { }

        public string EntityType { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
