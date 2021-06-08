using System.Collections.Generic;

namespace Traveller.RouteService.DataContainer
{
    public class MonzonDataContainer 
    {
        public List<CharRange> monsoonDaysData = new List<CharRange>();

        public MonzonDataContainer()
        {
            string SudoesteMonzonMalasia = "Del otro lado, en la costa oeste, donde se sitúan Kuala Lumpur, Penang y Langkawi, el monzón es un poco más benevolente y no hay una estación de lluvias muy definida. Aun así, los mejores meses son enero, febrero, junio, julio y agosto.Si no quieres sacar el paraguas demasiado, ten en cuenta que los momentos más lluviosos suelen darse en marzo, abril, mayo, septiembre, octubre y noviembre, cuando el monzón del suroeste está más activo.El monzón del sudoeste se extiende de abril a octubre, y afecta especialmente a la costa oeste de Malasia Peninsular.Trae lluvias a la zona de Kuala Lumpur, la capital de Malasia, Malaca, Penang y Langkawi, donde la lluvia suele ser especialmente intensa en septiembre y octubre.";

            monsoonDaysData = new List<CharRange> {
                new CharRange { Id = 'M', Description = new Dictionary<char, string>()
                    {
                    { 'A', SudoesteMonzonMalasia}, //Grandes LLuvias
                    { 'M', SudoesteMonzonMalasia},
                    { 'B', SudoesteMonzonMalasia}, //Intensidad Monzon Baja
                    },

                    Values = new List<char> { 'B', 'B', 'A', 'A', 'A', 'M', 'M', 'M', 'A', 'A', 'M', 'A', } } ,
                    };
                
               



        }


    }

}