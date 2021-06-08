using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace GraphicMap.Coordinates
{
    public class CountriesScreenCoordinates
    {
        public CountriesScreenCoordinates () {}

        public  List<Tuple<char, char, Point>> Coordinates = new List<Tuple<char, char , Point>>
        {

            //Primer caracter pais //Segundo Tipo C = Countru R = En Ruta T = Tourist Destination
                Tuple.Create('T', 'C', new Point( 199,485)),
                Tuple.Create('M', 'C', new Point(268, 649)),
                Tuple.Create('L', 'C', new Point(298, 231)),
                Tuple.Create('V', 'C', new Point(433, 358)),
                Tuple.Create('B', 'C', new Point(140, 177)),
                Tuple.Create('H', 'R', new Point(487, 277)),
                Tuple.Create('C', 'C', new Point(342, 439)),
                Tuple.Create('G', 'C', new Point(312, 730)),
                Tuple.Create('I', 'C', new Point(606,992)),
                Tuple.Create('W', 'R', new Point(229,612)),
                Tuple.Create('N', 'R', new Point(227, 302)),
                Tuple.Create('O', 'R', new Point(605, 992)),
                Tuple.Create('A', 'T', new Point(326,410)),

                Tuple.Create('X', 'C', new Point(353,339)),





    };




    }
}
