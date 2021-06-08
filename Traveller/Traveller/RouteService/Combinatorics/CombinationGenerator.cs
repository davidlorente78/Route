using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Traveller.RouteService
{
    public class CombinationGenerator : IGenerator
    {

        public  IEnumerable<IEnumerable<T>>
        Generate<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });

            return Generate(list, length - 1)
                .SelectMany(t => list, (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
}
