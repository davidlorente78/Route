using System.Collections.Generic;

namespace Traveller.RouteService.Rules
{
    public class MustStartCountries : IRule    {
               
        List<char> countries = new List<char>();
        Month StartTravelMonth;
        public MustStartCountries(List<char> countries, Month StartTravelMonth) {

            this.countries = countries;
            this.StartTravelMonth = StartTravelMonth;
        }
        public bool Validate(List<char> route)
        {
            if (countries.Contains(route[(int)StartTravelMonth])) return true;
            else return false;
        }
        
        
        public override string ToString()
    {
        string summmary = "";

            summmary = summmary + "La ruta debe empezar en cualquiera de estos paises ... en " + StartTravelMonth.ToString();  //TODO

        return summmary;


    }
    }

    

    public enum Month { jan, feb, march, april, may, june, july, aug, sept, oct, nov, dec };
}
