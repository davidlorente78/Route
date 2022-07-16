

using Domain.Ranges.WithDictionary;
using System.Collections.Generic;

namespace Traveller.RouteService.DataContainer
{

    public enum Temporada { Alta = 'A', Baja = 'B', Media = 'M' };
    public class SeasonDataContainer
    {
        public List<RangeCharWithDictionary> rangesList = new List<RangeCharWithDictionary>();

        public SeasonDataContainer()
        {
            //TODO Leer todos desde el repositorio

            rangesList = new List<RangeCharWithDictionary> {

                //Migrated
                new RangeCharWithDictionary { Id = 'T', Description = new Dictionary<char, string>()
                    {
                    { (char) Temporada.Alta, "Navidad y Año Nuevo son las épocas más turísticas y caras."},
                    { 'M', "El norte y la costa del golfo son ideales en septiembre y octubre."},
                    { 'B', "Algunas islas cierran y, según el tiempo, circulan menos barcos; se recomienda cierto margen de maniobra." }
                    },
                    Values = new List<char> { 'A', 'A', 'A', 'M', 'M', 'M', 'B', 'B', 'M', 'M', 'A', 'A', } } ,

                new RangeCharWithDictionary { Id = 'N', Description = new Dictionary<char, string>()
                    {
                    { 'A', "Navidad y Año Nuevo son las épocas más turísticas y caras."},
                    { 'M', "El norte y la costa del golfo son ideales en septiembre y octubre."},
                    { 'B', "Algunas islas cierran y, según el tiempo, circulan menos barcos; se recomienda cierto margen de maniobra." }
                    },
                    Values = new List<char> { 'A', 'A', 'A', 'M', 'M', 'M', 'B', 'B', 'M', 'M', 'A', 'A', } } ,

                //Migrated
                new RangeCharWithDictionary { Id = 'L',   Description = new Dictionary<char, string>()
                    {
                    { 'A', "La mejor época. Se recomienda reservar alojamiento con antelación para el período navideño y Año Nuevo."},
                    { 'M', "Los paisajes verdes son preciosos. Temporada preferida por los viajeros españoles, además de mochileros de todo el mundo."},
                    { 'B', "En abril y mayo hace calor, con temperaturas de hasta 40ºC. En septiembre y octubre puede llover bastante, aunque los diluvios van acompañados de increíbles formaciones de nubes. " }
                    },
                    Values = new List<char> { 'A', 'A', 'A', 'B', 'B', 'B', 'M', 'M', 'B', 'B', 'A', 'A', } } ,

                //Migrated
                new RangeCharWithDictionary
                {
                Id = 'M',
                Description = new Dictionary<char, string>()
                    {
                    { 'A', "Las vacaciones escolares de fin de año, seguidas del Año Nuevo chino, elevan los precios y conviene reservar el transporte y el alojamiento. Es temporada del monzón en la costa este de la Malasia peninsular y el oeste de Sarawak."},
                    { 'M', "De julio a agosto se competirá con los visitantes de los estados del Golfo que escapan del calor; es la llamada “temporada árabe”. Es temporada del monzón en la costa oeste de la Malasia peninsular hasta septiembre."},
                    { 'B', "Conviene evitar la peor época de lluvias y humedad.Es cuando más tranquilo se puede disfrutar de ciertos lugares muy turísticos." }
                    },
                Values = new List<char> { 'A', 'A', 'B', 'B', 'B', 'B', 'M', 'M', 'M', 'M', 'M', 'B', } ,
                 } ,

                new RangeCharWithDictionary
                {
                Id = 'W',
                Description = new Dictionary<char, string>()
                    {
                    { 'A', "Las vacaciones escolares de fin de año, seguidas del Año Nuevo chino, elevan los precios y conviene reservar el transporte y el alojamiento. Es temporada del monzón en la costa este de la Malasia peninsular y el oeste de Sarawak."},
                    { 'M', "De julio a agosto se competirá con los visitantes de los estados del Golfo que escapan del calor; es la llamada “temporada árabe”. Es temporada del monzón en la costa oeste de la Malasia peninsular hasta septiembre."},
                    { 'B', "Conviene evitar la peor época de lluvias y humedad. Es cuando más tranquilo se puede disfrutar de ciertos lugares muy turísticos." }
                    },
                Values = new List<char> { 'A', 'A', 'B', 'B', 'B', 'B', 'M', 'M', 'M', 'M', 'M', 'B', } ,
                 } ,
                //Migrated
                new RangeCharWithDictionary { Id = 'V',
                    Description = new Dictionary<char, string> ()
                    {
                    { 'A', "Los precios suben hasta un 50 % en la costa; se recomienda reservar hotel con antelación."},
                    { 'M', "Durante la celebración del Tet, todo el país se moviliza y los precios suben."},
                    { 'B', "Probablemente la mejor época para recorrer el país." }
                    },
                    Values = new List<char>  {'M', 'M', 'M', 'B', 'B', 'B', 'A', 'A', 'B', 'B', 'B', 'M', } } ,
                //Migrated
                new RangeCharWithDictionary { Id = 'C',   Description = new Dictionary<char, string>()
                    {
                    { 'A', "Más fresco y ventoso, con temperaturas casi mediterráneas. Es mejor reservar alojamiento por anticipado en Navidad y Año Nuevo.."},
                    { 'M', "En abril y mayo, el termómetro alcanza los 40°C. Octubre y noviembre son magníficos para viajar: llueve menos pero aún no ha empezado la temporada seca.."},
                    { 'B', "Los descuentos en alojamientos y las nubes hacen que sea una buena época para visitar los templos. La costa sur puede estar atestada de turistas occidentales." }
                    },
                    Values = new List<char> { 'A', 'A', 'M', 'M', 'B', 'B', 'B', 'B', 'B', 'M', 'A', 'A', } } ,

                new RangeCharWithDictionary { Id = 'I', Description = new Dictionary<char, string>()
                    {
                    { 'A', "Oleadas de turistas atraviesan todo el país. Las tarifas pueden aumentar en un 50%. Estación seca salvo en Molucas y Papúa, que son lluviosas."},
                    { 'M', "Se puede viajar de forma más improvisada. Mejor tiempo en Java, Bali y Lombok (seco, menos húmedo)."},
                    { 'B', "Fácil encontrar ofertas; casi nunca hay que reservar (salvo Navidad y Nochevieja). Estación de lluvias en Java, Bali y Lombok (Flores en Kalimantán). Estación seca (mejor para bucear) en Molucas y Papúa." }
                    },
                    Values = new List<char> { 'B', 'B', 'B', 'B', 'M', 'M', 'A', 'A', 'M', 'M', 'B', 'B', } } ,

                new RangeCharWithDictionary { Id = 'O', Description = new Dictionary<char, string>()
                    {
                    { 'A', "Oleadas de turistas atraviesan todo el país. Las tarifas pueden aumentar en un 50%. Estación seca salvo en Molucas y Papúa, que son lluviosas."},
                    { 'M', "Se puede viajar de forma más improvisada. Mejor tiempo en Java, Bali y Lombok (seco, menos húmedo)."},
                    { 'B', "Fácil encontrar ofertas; casi nunca hay que reservar (salvo Navidad y Nochevieja). Estación de lluvias en Java, Bali y Lombok (Flores en Kalimantán). Estación seca (mejor para bucear) en Molucas y Papúa." }
                    },
                    Values = new List<char> { 'B', 'B', 'B', 'B', 'M', 'M', 'A', 'A', 'M', 'M', 'B', 'B', } } ,

                new RangeCharWithDictionary { Id = 'Z', Description = new Dictionary<char, string>()
                    {
                    { 'A', "Tiempo para salir del circulo."},
                    { 'M',  "Tiempo para salir del circulo."},
                    { 'B',  "Tiempo para salir del circulo."},
                    },

                    Values = new List<char> { 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', 'M', } } ,

            };

        }


    }

}