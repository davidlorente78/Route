using System.Collections.Generic;

namespace Traveller.RouteService.DataContainer
{
    public class RainyDaysDataContainer
    {
        public List<CharRange> rainyDaysData = new List<CharRange>();
        //Range Genericos
        //Id
        public RainyDaysDataContainer() {


            rainyDaysData = new List<CharRange> {
                //Kuala Lumpur
                new CharRange { Id = 'K', Description = new Dictionary<char, string>()
                    {
                    { 'T', "25.1 25.7 26 26.1 26.3	26.2 26.1 25.8 25.7 25.2 25.1"}, //Average Temperature
                    { 'R', "209 174 268 300 246 174 183 219 243 308 373 284" }, //Rainfall mm
                    { 'H', "85%   82% 85% 87% 87% 85% 84% 84% 85% 87% 90% 88%"}, //Humidity
                    { 'D',"20  18  24  27  25  22  24  24  25  26  26  24"} //Rainy Days



                   } } ,
                //Bangkok
                 new CharRange {  Id = 'B', Description = new Dictionary<char, string>()
                    {
                    { 'T', "26 	27.4 28.8 29.9 29.1 28.5 28 27.8 27.3 27 26.7 25.9 "},
                    { 'R', "18	15	45	72	137	133	141	150	244	196	46	10" },
                    { 'H', "63%	67%	68%	69%	75%	76%	77%	77%	81%	81%	69%	60%"},
                    { 'D',"3	3	7	11	21	21	23	24	24	20	7	2"}


                   }

                 } };


            //Bali 20	18	19	16	14	12	13	11	11	13	16	20
            //Siem Reap 2	2	6	11	16	15	16	17	18	17	7	2
            //Hanoi 7	7	9	9	13	14	15	17	13	9	6	6
            //Nha TRang 11	7	8	8	13	13	15	15	18	19	17	16
            //Ho Chi Min 3	1	4	9	18	19	21	21	20	19	13	7


        }


    }

}