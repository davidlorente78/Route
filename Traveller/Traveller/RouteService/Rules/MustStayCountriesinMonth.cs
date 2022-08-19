using System.Collections.Generic;

namespace Traveller.RouteService.Rules
{
    public class MustStayCountriesinMonth : IRule
    {
        List<char> countries = new List<char>();
        Month StayTravelMonth;
        public MustStayCountriesinMonth(List<char> countries, Month StayTravelMonth)
        {

            this.countries = countries;
            this.StayTravelMonth = StayTravelMonth;
        }
        public bool Validate(List<char> route)
        {
            if (countries.Contains(route[(int)StayTravelMonth])) return true;
            else return false;
        }

        public override string ToString()
        {
            string summmary = "";

            summmary = summmary + "Se debe pasar el mes de  " + StayTravelMonth.ToString() + " en alguno de los siguiente paises.";  //TODO

            return summmary;


        }
    }
}

