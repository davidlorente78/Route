using System.Collections.Generic;
using Traveller.Domain;

namespace Traveller.RouteService.Rules
{
    public class MustConsiderWeather : IRule
    {

        List<IntegerRange> ranges = new List<IntegerRange>();
        public MustConsiderWeather(List<IntegerRange> ranges)
        {

            this.ranges = ranges;
        }

        public bool Validate(List<char> route)
        {
            //TODO Debe buscar todas las ocurrencias no solo la primera!!!
            foreach (IntegerRange range in ranges)
            {

                //Buscar posiciones de weatherRange.Country en route
                string s = string.Join("", route);
                char ch = range.Id;
                int idx = s.IndexOf(ch);

                for (int x = 0; x < route.Count; x++)
                {

                    if ((route[x] == ch) && (range.Values[x] == -1)) return false;


                }




            }

            return true;
        }

        public List<char> MonthReport(int month)
        {
            List<char> Countries = new List<char>();
            foreach (IntegerRange weatherRange in ranges)
            {
                char ch = weatherRange.Id;


                if (weatherRange.Values[(int)month] == 1) Countries.Add(ch);

            }

            return Countries;

        }

        public override string ToString()
        {
            string summmary = "";

            summmary = summmary + "Se considera el clima de : ";
            foreach (IntegerRange weatherRange in ranges)
            {
                summmary = summmary + CodeDictionary.GetCountryByCode(weatherRange.Id) + " ";
            }

            return summmary;
        }
    }
}
