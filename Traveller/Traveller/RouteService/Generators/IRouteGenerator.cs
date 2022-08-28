using System.Collections.Generic;

namespace Traveller
{
    public interface IRouteGenerator 
    {
        public List<List<char>> Generate(int Months);
    }
}