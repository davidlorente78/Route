using Coordinates_One;
using System;
using System.Drawing;

namespace GraphicMap
{
    class ScreenCoordinates
    {
        public static UTM IniVertexNW = new UTM(257995, 4752005);
        static int IniCellSize = 30;
        public  Point ConvertUTMCoordinatesToGraphicPoint(UTM UTM, Point Vertex, int CellSize)
        {         
            Point GraphicPoint = new Point(0, 0);
            GraphicPoint.X = Convert.ToInt16((UTM.Easting - IniVertexNW.Easting - (Vertex.X * IniCellSize)) / CellSize);
            GraphicPoint.Y = Convert.ToInt16(-(UTM.Northing - IniVertexNW.Northing + (Vertex.Y * IniCellSize)) / CellSize);
            return GraphicPoint;
        }

        public UTM ConvertToUTM(Point ClickImage, Point VertexImage, int CellSize)
        {           

            double UTMEasting = IniVertexNW.Easting + VertexImage.X * IniCellSize + ClickImage.X * CellSize;
            double UTMNorthing = IniVertexNW.Northing - VertexImage.Y * IniCellSize - ClickImage.Y * CellSize;
            UTM ToReturn = new UTM(UTMEasting, UTMNorthing);
            return ToReturn;

        }

      

    }
}
