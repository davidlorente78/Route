using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Domain;

namespace Domain.Repositories
{
    /// <summary>
    /// You can see that the interface and implementations are quite blank. So why create new class and interface for Project? This can also attribute to a good practice while developing applications. We also anticipate that in future, there can be functions that are spcific to the Project Entity. To support them later on, we provide with interfaces and classes. 
    /// </summary>
    public interface IFrontierRepository : IGenericRepository<Frontier>
    {
    }
}
