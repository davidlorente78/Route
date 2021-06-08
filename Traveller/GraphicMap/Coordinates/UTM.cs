using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Coordinates_One
{
    [Serializable]
    public class UTM
    {
        private double _x;
        private double _y;
        private double Huso = 47;
        private double ScaleFactor = 0.9996;
        private double X;
        private double Y;
        private double latitudeDegrees;
        private double longitudeDegrees;
        private int IniCellSize = 865; // 665000/762;
        //Primer parametro Utm_x es Easting segundo Northing
        

        public UTM() { }

        public UTM(double UTM_x, double UTM_y)
        {
            //Constructor
            _x = UTM_x;
            _y = UTM_y;

            //my x y y estan intercambiadas por verticeNW con coordenadas cartesianas, no?

            //Retranqueo X

            X = _x - 500000;
            Y = _y;
            //y = -10000000 si Hemisferio Sud

            double MyLatitudeRadians = Y / (6366197.724 * ScaleFactor);

            double CenterMeridian = Huso * 6 - 183;  //Signo - ¿?           
            double DesplazamientoCentro = MyLatitudeRadians - CenterMeridian * Math.PI / 180;

            //Internacional 1924
            double a = 6378388;
            double b = 6356911.946;

            //Elipsoide Hayford
            //double a = 6378388;
            //double b = 6356915.946130;

            //WGS84
            //double a = 6378137;
            //double b = 6356752.314;

            double e = Math.Sqrt(a * a - b * b) / a;
            double e2 = Math.Sqrt(a * a - b * b) / b; //Es un mas en A1
            double e2Squared = Math.Pow(e2, 2);

            double c = a * a / b;
            double aplanamiento = a - b / a;



            double v = c * ScaleFactor / Math.Sqrt((1 + e2Squared * Math.Pow(Math.Cos(MyLatitudeRadians), 2)));
            //6375620,802

            double aprima = X / v;
            //0,666916232

            double A1 = Math.Sin(MyLatitudeRadians * 2); //0,080995133

            double A2 = A1 * Math.Pow(Math.Cos(MyLatitudeRadians), 2);

            double J2 = MyLatitudeRadians + A1 / 2;
            double J4 = (3 * J2 + A2) / 4;
            double J6 = (5 * J4 + A2 * Math.Pow(Math.Cos(MyLatitudeRadians), 2)) / 3; //0,161901709

            double alfa = 3 * e2Squared / 4; //0,005054623
            //alfa = 0.005054623;
            double beta = (5 * alfa * alfa) / 3; //4,2582E-05

            //double gamma = (35 / 27) * Math.Pow(alfa, 3); //1,67406E-07

            double gamma = (35 * alfa * alfa * alfa) / 27; //Argh!!!!!!
            double B = ScaleFactor * c * (MyLatitudeRadians - alfa * J2 + beta * J4 - gamma * J6); //256749,9034

            double bprima = (Y - B) / v; //0,00019529

            double chishort = (e2Squared * aprima * aprima) / 2 * Math.Pow(Math.Cos(MyLatitudeRadians), 2);
            double chi = aprima * (1 - chishort / 3); //0,66658359

            double eta = bprima * (1 - chishort) + MyLatitudeRadians; //0,040736975

            //cambio chi por chishort aqui !!! Pendiente revisar Cris Space

            //double sinhchi = (Math.Pow(-chi, Math.E) - Math.Pow(chi, Math.E))/2; //Nan
            double sinhchi = Math.Sinh(chi); //0,717056232

            double deltalambda = Math.Atan(sinhchi / Math.Cos(eta)); //0,622474716

            double tau = Math.Atan(Math.Cos(deltalambda) * Math.Tan(eta)); //0,033102493

            //Calculo final 
            longitudeDegrees = deltalambda / Math.PI * 180 + CenterMeridian; //En Grados 38,66517409

            double MyLatitudeRad = MyLatitudeRadians + (1 + e2Squared * Math.Pow(Math.Cos(MyLatitudeRadians), 2) - (3 / 2) * e2Squared * Math.Sin(MyLatitudeRadians) * Math.Cos(MyLatitudeRadians) * (tau - MyLatitudeRadians)) * (tau - MyLatitudeRadians); //Radians
            latitudeDegrees = MyLatitudeRad / Math.PI * 180;
            //1,89376 3826

            //0,033052414
            //Resultado coincide con Ortiz

        }
        /// <summary>
        /// Componente Easting (Cuidado que en pantalla sigue el eje y)
        /// </summary>
        public double Easting
        {

            get { return (_x); }
            set { _x = value; }
        }

        /// <summary>
        /// Componente Northing (Cuidado que en pantalla sigue el eje x)
        /// </summary>
        public double Northing
        {

            get { return (_y); }
            set { _y = value; }
        }


        /// <summary>
        /// Convierte Coordenada UTM a Geografica
        /// </summary>
        /// <returns></returns>
        public GeographicCoordinate ConvertToGeographic()
        {


            double latitudeGrades = Math.Truncate(latitudeDegrees);
            double latitudeMinutes = Math.Truncate((latitudeDegrees - latitudeGrades) * 60);
            double latitudeSeconds = ((latitudeDegrees - latitudeGrades) * 60 - latitudeMinutes) * 60;

            double longitudeGrades = Math.Truncate(longitudeDegrees);
            double longitudeMinutes = Math.Truncate((longitudeDegrees - longitudeGrades) * 60);
            double longitudeSeconds = ((longitudeDegrees - longitudeGrades) * 60 - longitudeMinutes) * 60;

            GeographicCoordinate geographic = new GeographicCoordinate(latitudeGrades, latitudeMinutes, latitudeSeconds, longitudeGrades, longitudeMinutes, longitudeSeconds);

            return geographic;


        }


        /// <summary>
        /// Convierte UTM a Coordenadas referidas a Vertice NW de fichero
        /// </summary>
        /// <returns></returns>
        public UTM ConvertUTMToVertexCoordinates()
        {           
            UTM Vx = new UTM((this.Easting - 167500) / IniCellSize, (880000 - this.Northing) / IniCellSize);
            return Vx;
        }


        //Existe copia de este metodo en formulario
        //test
        public Point ConvertUTMCoordinatesToGraphicPoint(Point Vertex, int CellSize)
        {
           

            Point GraphicPoint = new Point(0, 0);
            GraphicPoint.X = Convert.ToInt16((this.Easting - 167500 - Vertex.X * IniCellSize) / CellSize);
            GraphicPoint.Y = Convert.ToInt16(-(this.Northing - 880000 + Vertex.Y * IniCellSize) / CellSize);   
          
            return GraphicPoint;





        }
    }
}
