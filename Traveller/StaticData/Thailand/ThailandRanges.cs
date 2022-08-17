using Domain.EntityFrameworkDictionary;
using Domain.Ranges;

namespace StaticData.Thailand
{
    public class ThailandRanges
    {
        public static RangeChar SeasonRange = new RangeChar
        {
            RangeType = RangeTypes.TourismSeasonRangeType,
            EntityKey_Description = new EntityFrameworkDictionary<char>()
            {
                Dictionary = new List<DictionaryItem<char>>()
                {

                    new DictionaryItem<char> { DictionaryKey = 'A', DictionaryValue = "Navidad y Año Nuevo son las épocas más turísticas y caras."},
                    new DictionaryItem<char> { DictionaryKey = 'M', DictionaryValue = "El norte y la costa del golfo son ideales en septiembre y octubre."},
                    new DictionaryItem<char> { DictionaryKey = 'B', DictionaryValue = "Algunas islas cierran y, según el tiempo, circulan menos barcos; se recomienda cierto margen de maniobra." }
                }

            }
            ,

            EntityKey_ByMonth = new EntityFrameworkDictionary<string>()
            {

                Dictionary = new List<DictionaryItem<string>>()
                {

                    new DictionaryItem<string> { DictionaryKey = "January", DictionaryValue ="A" },

                    new DictionaryItem<string> { DictionaryKey = "February", DictionaryValue ="A" },

                    new DictionaryItem<string> { DictionaryKey = "March", DictionaryValue ="A" },

                    new DictionaryItem<string> { DictionaryKey = "April", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "May", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "June", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "July", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "August", DictionaryValue ="B" },

                    new DictionaryItem<string> { DictionaryKey = "September", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "October", DictionaryValue ="M" },

                    new DictionaryItem<string> { DictionaryKey = "November", DictionaryValue ="A" },

                    new DictionaryItem<string> { DictionaryKey = "December", DictionaryValue ="A" },

                }

            }

        };

        public static RangeChar MonzonRange = new RangeChar
        {
            //Este tipo de diccionario es distinto al de Season y los valores del segundo diccionario no estan relacionados con las key del primero. 
            RangeType = RangeTypes.MonsoonSeasonRangeType,
            EntityKey_Description = new EntityFrameworkDictionary<char>()
            {
                Dictionary = new List<DictionaryItem<char>>()
                {

                    new DictionaryItem<char> { DictionaryKey = 'S', DictionaryValue = "Temporada de lluvias o monzón del suroeste (mediados de mayo a mediados de octubre). El monzón prevalece en el suroeste de Tailandia aunque llueve en todo el país. Las precipitaciones son todavía más intensas de agosto a septiembre. En el sur de Tailandia el clima es un poco diferente porque las lluvias permanecen hasta el final del año, que es el período inicial del monzón del noreste, siendo noviembre el mes más húmedo." },
                    new DictionaryItem<char> { DictionaryKey = 'I', DictionaryValue = "Temporada de invierno o monzón del noreste (mediados de octubre a mediados de febrero). Este es el período suave del año con bastante frío en diciembre y enero en la zona norte de Tailandia, pero con fuertes precipitaciones en la costa este de Tailandia, especialmente de octubre a noviembre."},
                    new DictionaryItem<char> { DictionaryKey = 'V', DictionaryValue = "Temporada de verano o pre-monzón (mediados de febrero a mediados de mayo). Este es el período de transición de los monzones del noreste al suroeste. El clima se hace más caliente, especialmente en la parte superior de Tailandia. Abril es el mes más cálido." },

               }

            }
            ,

            EntityDescription_ByMonth = new EntityFrameworkDictionary<string>()
            {

                Dictionary = new List<DictionaryItem<string>>()
                {

                    new DictionaryItem<string> { DictionaryKey = "January", DictionaryValue ="Enero es uno de los mejores meses del año para viajar a Tailandia, con condiciones climáticas favorables en todo el país. De hecho es uno de los meses más populares entre los turistas que llegan de todas partes del mundo. El norte de Tailandia suele ser fresco y seco y las temperaturas nocturnas en el extremo norte pueden ser un poco frías. En Bangkok el tiempo es más cálido y seco, con temperaturas rondando los 20-23°C durante todo el mes." },

                    new DictionaryItem<string> { DictionaryKey = "February", DictionaryValue ="En gran parte del norte de Tailandia como Chiang Mai o Chiang Rai es probable que el clima sea fresco y seco, con pocas posibilidades de lluvia. Estas condiciones climáticas favorables hacen de febrero un mes ideal para las actividades al aire libre por el norte y proporcionan un descanso del calor más al sur. En Bangkok el ambiente es más seco todavía y las temperaturas son más cálidas que en el norte debido a la baja altitud." },

                    new DictionaryItem<string> { DictionaryKey = "March", DictionaryValue ="En marzo la temperatura empieza a ascender en toda Tailandia y se nota especialmente en Chiang Mai y el resto del norte del país donde el fresquito desaparece y da paso al verano. Durante este mes la temperatura puede llegar a 35°C durante el día y hay poca probabilidad de lluvia." },

                    new DictionaryItem<string> { DictionaryKey = "April", DictionaryValue ="A no ser que te encante el calor, evita ir a Tailandia en abril. Este es el mes más caluroso del año en todo el país, y el clima resulta asfixiante, especialmente para los viajeros que no se aclimatan bien a estas temperaturas. El intenso calor y la humedad en Tailandia con el monzón acercándose es agotador, así que si no tienes más remedio que venir en abril busca alojamiento con aire acondicionado…" },

                    new DictionaryItem<string> { DictionaryKey = "May", DictionaryValue ="Muy esperado por la gente local, el mes de mayo trae consigo el monzón y el agobiante calor del mes anterior se disipa. Aunque para los turistas no es tan agradable, no te desesperes porque la temporada de lluvias en Tailandia no es sinónimos de días grises sino de lluvias fuertes que duran un rato y en pocos minutos dan paso al sol otra vez." },

                    new DictionaryItem<string> { DictionaryKey = "June", DictionaryValue ="El mes de junio es muy húmedo y el monzón del suroeste se desplaza hacia el centro del país. Las temperaturas descienden ligeramente debido a las tormentas durante las tardes y las noches y el sol brilla la mayor parte del tiempo cuando no está lloviendo. La parte positiva es que el agua transforma el paisaje y hace que el campo esté verde y los ríos caudalosos. Cuidado con las inundaciones repentinas y las sanguijuelas." },

                    new DictionaryItem<string> { DictionaryKey = "July", DictionaryValue ="Julio es un mes de intensas lluvias aunque el sol se deja ver y el calor vuelve a hacer acto de presencia. La costa de Andaman es especialmente húmeda, pero aun así vas a tener la oportunidad de volver del viaje bronceado. Es la mejor época para ver las cascadas en todo su esplendor. Cuidado con los deslizamientos de tierra e inundaciones repentinas. El mar puede estar agitado en la costa oeste de Tailandia." },

                    new DictionaryItem<string> { DictionaryKey = "August", DictionaryValue ="Las lluvias van a más en agosto, siendo el noreste de Tailandia la zona con precipitaciones más pronunciadas. En algunos lugares como Bangkok y la provincia de Trat sufren inundaciones durante todo el mes." },

                    new DictionaryItem<string> { DictionaryKey = "September", DictionaryValue ="Las islas de la costa del golfo, como Koh Samui, Koh Phangan y Koh Tao, son los mejores destinos para unas vacaciones en Tailandia en septiembre, siendo más secas y más frías que el resto del país. Aunque esto no significa que estas islas se salven completamente del monzón. El centro de Tailandia y Bangkok sufren las peores lluvias durante septiembre, y la costa de Andamán es extremadamente húmeda con un mar agitado." },

                    new DictionaryItem<string> { DictionaryKey = "October", DictionaryValue ="Todavía llueve en las islas de Tailandia y las regiones costeras del sur en octubre, pero el monzón comienza a retirarse de las áreas centrales, del norte y del noreste del país. En Bangkok y Tailandia central, octubre todavía trae algunas lluvias, pero su frecuencia, duración y volumen disminuye drásticamente, particularmente en la segunda mitad del mes, cuando el viento empieza a cambiar de dirección. Del mismo modo, la lluvia se retira del norte, que disfruta de temperaturas moderadas. Es un momento agradable para pasar unas vacaciones en esta zona, especialmente para el senderismo." },

                    new DictionaryItem<string> { DictionaryKey = "November", DictionaryValue ="En noviembre, la lluvia prácticamente ha desaparecido de gran parte de Tailandia, sobre todo a finales de mes. La humedad desaparece y las temperaturas se mantienen relativamente bajas (para el estándar tailandés). Noviembre es un buen momento del año para visitar Chiang Mai, Chiang Rai y el norte de Tailandia, la región goza de días soleados, predominantemente secos y con temperaturas agradables propicias para actividades al aire libre, aunque hay que tener en cuenta que las temperaturas nocturnas en el norte puede ser un poco frías." },

                    new DictionaryItem<string> { DictionaryKey = "December", DictionaryValue ="Diciembre es uno de los mejores meses del año para viajar a Tailandia: prácticamente no llueve, las temperaturas son agradables y hace mucho sol sin llegar a ser sofocante. Los niveles bajos de humedad y una temperatura media de 26°C en el centro de Tailandia y Bangkok son ideales para el turismo. El norte del país también goza de condiciones climáticas favorables para el senderismo en la región del Triángulo de Oro y por el campo de Chiang Mai, con temperaturas ligeramente más frías que en Bangkok (temperatura media: 23-25°C)." },

                }

            }

        };
    }
}
