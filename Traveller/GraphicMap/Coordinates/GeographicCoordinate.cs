using System;
//HSV

namespace Coordinates_One
{
    [Serializable]
    public class GeographicCoordinate
    {   //Atributos como My
        private double MyLatitudeGrades;
        private double MyLatitudeMinutes;
        private double MyLatitudeSeconds;
        private double MyLatitudeRadians;
        private double MyLatitudeDegrees;

        private double MyLongitudeGrades; //Grados
        private double MyLongitudeMinutes;
        private double MyLongitudeSeconds;
        private double MyLongitudeRadians; //Radianes
        private double MyLongitudeDegrees; //Grados decimanles

        private double X;
        private double Y;


        private double Huso;
        private double DesplazamientoCentro;
        private double CenterMeridian;

        //Elipsoide
        private double a; //Semieje mayor
        private double b; //Semieje menor
        private double e; //Excentricidad
        private double e2; //Segunda Excentricidad
        private double e2Squared; //Cuadrado segunda excentridad
        private double c; //Radio polar curvatura
        private double aplanamiento; //Aplanamiento


        public GeographicCoordinate()
        {
            //Only Serializable
        }

        public GeographicCoordinate(double LatitudeDegrees, double LongitudeDegrees)
        {

            MyLatitudeDegrees = LatitudeDegrees;
            MyLongitudeDegrees = LongitudeDegrees;

            MyLatitudeGrades = Math.Truncate(MyLatitudeDegrees);
            MyLatitudeMinutes = Math.Truncate((MyLatitudeDegrees - MyLatitudeGrades) * 60);
            MyLatitudeSeconds = Math.Truncate((MyLatitudeDegrees - MyLatitudeGrades) * 60 - MyLatitudeMinutes) * 60;

            MyLongitudeGrades = Math.Truncate(MyLongitudeDegrees);
            MyLongitudeMinutes = Math.Truncate((MyLongitudeDegrees - MyLongitudeGrades) * 60);
            MyLongitudeSeconds = Math.Truncate((MyLongitudeDegrees - MyLongitudeGrades) * 60 - MyLongitudeMinutes) * 60;



        }


        public GeographicCoordinate(double LatitudeGrades, double LatitudeMinutes, double LatitudeSeconds, double LongitudeGrades, double LongitudeMinutes, double LongitudeSeconds)
        {
            double Huso = 47;

            /// Valores con triple marca son GeographicCoordinate GeoTest = new GeographicCoordinate(0,10,46,40,25,45);
            ///Trabajando con Internacional 1924
            MyLatitudeGrades = LatitudeGrades;
            MyLatitudeMinutes = LatitudeMinutes;
            MyLatitudeSeconds = LatitudeSeconds;
            MyLongitudeGrades = LongitudeGrades;
            MyLongitudeMinutes = LongitudeMinutes;
            MyLongitudeSeconds = LongitudeSeconds;

            //Convert Grades Minutes & Seconds to Radians 
            MyLongitudeDegrees = MyLongitudeGrades + MyLongitudeMinutes / 60 + MyLongitudeSeconds / 3600;//3,251715339

            MyLatitudeDegrees = MyLatitudeGrades + MyLatitudeMinutes / 60 + MyLatitudeSeconds / 3600;

            MyLatitudeRadians = MyLatitudeDegrees * Math.PI / 180; //0,737384363
            ///0,003131896

            MyLongitudeRadians = MyLongitudeDegrees * Math.PI / 180; //0,056753139

            ///0,705622072

            //Pendiente cambio signo segun WE Longitud
            //Si referida a W entonces negativa Para Catalunya todas son referidas a E
            //MyLongitudeRadians = -MyLongitudeRadians;
            //Etiquetas de letras en Form?

            //Huso y meridiano central
            Huso = Math.Truncate(MyLongitudeDegrees / 6 + 31);  //Convertir y truncar //Este 31 no es del Huso es de donde empieza el Este

            CenterMeridian = Huso * 6 - 183;  //Signo - ¿?

            //CenterMeridian = -CenterMeridian; //
            DesplazamientoCentro = MyLongitudeRadians - (CenterMeridian * Math.PI / 180);//0,004393261
            ///0,024943664 deltalamba en excel


            //Elipsoide Hayfdord
            //a = 6378388;
            //b = 6356915.946130;

            //WGS84
            //a=6378137;
            //b=6356752.314;

            //Internacional 1924
            this.a = 6378388;
            this.b = 6356911.946;


            e = Math.Sqrt(a * a - b * b) / a;
            e2 = Math.Sqrt(a * a - b * b) / b; //Es un mas en A1
            e2Squared = Math.Pow(e2, 2);

            c = a * a / b; //6399593,626

            aplanamiento = a - b / a;

            //Calculo parametros Coticchia-Surace
            double ScaleFactor = 0.9996;
            double A = Math.Cos(MyLatitudeRadians) * Math.Sin(DesplazamientoCentro); //0,003252012


            ///0,024940955

            double chi = (Math.Log((1 + A) / (1 - A), Math.E)) / 2; //0,003252024

            ///0,024946129

            double eta = Math.Atan(Math.Tan(MyLatitudeRadians) / Math.Cos(DesplazamientoCentro)) - MyLatitudeRadians;
            //4,80297E-06
            ///9,74558E-07

            double v = c * ScaleFactor / Math.Sqrt((1 + e2Squared * Math.Pow(Math.Cos(MyLatitudeRadians), 2)));
            //6385254,79

            ///6375836,855 Ni en Excel

            double chishort = (e2Squared / 2) * chi * chi * Math.Pow(Math.Cos(MyLatitudeRadians), 2);
            //1,95271E-08

            ///2,10593E-06

            double A1 = Math.Sin(MyLatitudeRadians * 2); //0,995392892



            ///0,006263752

            double A2 = A1 * Math.Pow(Math.Cos(MyLatitudeRadians), 2); //0,545415624


            ///0,00626369

            double J2 = MyLatitudeRadians + A1 / 2;//1,235080809
            ///0,006263772

            double J4 = (3 * J2 + A2) / 4; //1,062664513
            ///0,006263752

            double J6 = (5 * J4 + A2 * Math.Pow(Math.Cos(MyLatitudeRadians), 2)) / 3; //1,870725875


            ///0,012527463

            double alfa = 3 * e2Squared / 4; //0,005054623
            ///0,005076128

            double beta = (5 * alfa * alfa) / 3; //4,2582E-05
            ///4,29451E-05

            double gamma = (35 * Math.Pow(alfa, 3)) / 27; //Alfa 3 //1,67406E-07


            double B = ScaleFactor * c * (MyLatitudeRadians - alfa * J2 + beta * J4 - gamma * J6);
            //4677424,318

            ///19834,21889

            X = chi * v * (1 + chishort / 3) + 500000; //520765,0001			utm x easting


            ///659052,5571	ok

            Y = eta * v * (1 + chishort) + B; //4677454,987			utm y northing


            ///19840,43253	ok		

        }


        public UTM ConvertToUTM()
        {

            //Convierte a coordenadas UTM

            UTM UTM = new UTM(this.X, this.Y);
            return UTM;
        }


        public double LatitudeGrades
        {

            get { return MyLatitudeGrades; }

        }
        public double LatitudeMinutes
        {

            get { return MyLatitudeMinutes; }

        }

        public double LatitudeSeconds
        {

            get { return MyLatitudeSeconds; }

        }

        public double LatitudeDegrees
        {
            get { return MyLatitudeDegrees; }
            set { MyLatitudeDegrees = value; }
        }
        public double LongitudeGrades
        {

            get { return MyLongitudeGrades; }

        }
        public double LongitudeMinutes
        {

            get { return MyLongitudeMinutes; }

        }

        public double LongitudeSeconds
        {

            get { return MyLongitudeSeconds; }

        }

        public double LongitudeDegrees
        {

            get { return MyLongitudeDegrees; }
            set { MyLongitudeDegrees = value; }
        }

        public void FillUTMFromGeoDegrees()
        {
            MyLatitudeGrades = Math.Truncate(MyLatitudeDegrees);
            MyLatitudeMinutes = Math.Truncate((MyLatitudeDegrees - MyLatitudeGrades) * 60);
            MyLatitudeSeconds = Math.Truncate((MyLatitudeDegrees - MyLatitudeGrades) * 60 - MyLatitudeMinutes) * 60;

            MyLongitudeGrades = Math.Truncate(MyLongitudeDegrees);
            MyLongitudeMinutes = Math.Truncate((MyLongitudeDegrees - MyLongitudeGrades) * 60);
            MyLongitudeSeconds = Math.Truncate((MyLongitudeDegrees - MyLongitudeGrades) * 60 - MyLongitudeMinutes) * 60;



        }


        public void FillOtherParams()
        {


            //Convert Grades Minutes & Seconds to Radians 
            MyLongitudeDegrees = MyLongitudeGrades + MyLongitudeMinutes / 60 + MyLongitudeSeconds / 3600;//3,251715339

            MyLatitudeDegrees = MyLatitudeGrades + MyLatitudeMinutes / 60 + MyLatitudeSeconds / 3600;

            MyLatitudeRadians = MyLatitudeDegrees * Math.PI / 180; //0,737384363
            ///0,003131896

            MyLongitudeRadians = MyLongitudeDegrees * Math.PI / 180; //0,056753139

            ///0,705622072

            //Pendiente cambio signo segun WE Longitud
            //Si referida a W entonces negativa Para Catalunya todas son referidas a E
            //MyLongitudeRadians = -MyLongitudeRadians;
            //Etiquetas de letras en Form?

            //Huso y meridiano central
            Huso = Math.Truncate(MyLongitudeDegrees / 6 + Huso);  //Convertir y truncar


            CenterMeridian = Huso * 6 - 183;  //Signo - ¿?

            //CenterMeridian = -CenterMeridian; //
            DesplazamientoCentro = MyLongitudeRadians - (CenterMeridian * Math.PI / 180);//0,004393261
            ///0,024943664 deltalamba en excel


            //Elipsoide Hayfdord
            //a = 6378388;
            //b = 6356915.946130;

            //WGS84
            //a=6378137;
            //b=6356752.314;

            //Internacional 1924
            a = 6378388;
            b = 6356911.946;


            e = Math.Sqrt(a * a - b * b) / a;
            e2 = Math.Sqrt(a * a - b * b) / b; //Es un mas en A1
            e2Squared = Math.Pow(e2, 2);

            c = a * a / b; //6399593,626

            aplanamiento = a - b / a;

            //Calculo parametros Coticchia-Surace
            double ScaleFactor = 0.9996;
            double A = Math.Cos(MyLatitudeRadians) * Math.Sin(DesplazamientoCentro); //0,003252012


            ///0,024940955

            double chi = (Math.Log((1 + A) / (1 - A), Math.E)) / 2; //0,003252024

            ///0,024946129

            double eta = Math.Atan(Math.Tan(MyLatitudeRadians) / Math.Cos(DesplazamientoCentro)) - MyLatitudeRadians;
            //4,80297E-06
            ///9,74558E-07

            double v = c * ScaleFactor / Math.Sqrt((1 + e2Squared * Math.Pow(Math.Cos(MyLatitudeRadians), 2)));
            //6385254,79

            ///6375836,855 Ni en Excel

            double chishort = (e2Squared / 2) * chi * chi * Math.Pow(Math.Cos(MyLatitudeRadians), 2);
            //1,95271E-08

            ///2,10593E-06

            double A1 = Math.Sin(MyLatitudeRadians * 2); //0,995392892



            ///0,006263752

            double A2 = A1 * Math.Pow(Math.Cos(MyLatitudeRadians), 2); //0,545415624


            ///0,00626369

            double J2 = MyLatitudeRadians + A1 / 2;//1,235080809
            ///0,006263772

            double J4 = (3 * J2 + A2) / 4; //1,062664513
            ///0,006263752

            double J6 = (5 * J4 + A2 * Math.Pow(Math.Cos(MyLatitudeRadians), 2)) / 3; //1,870725875


            ///0,012527463

            double alfa = 3 * e2Squared / 4; //0,005054623
            ///0,005076128

            double beta = (5 * alfa * alfa) / 3; //4,2582E-05
            ///4,29451E-05

            double gamma = (35 * Math.Pow(alfa, 3)) / 27; //Alfa 3 //1,67406E-07


            double B = ScaleFactor * c * (MyLatitudeRadians - alfa * J2 + beta * J4 - gamma * J6);
            //4677424,318

            ///19834,21889

            X = chi * v * (1 + chishort / 3) + 500000; //520765,0001			utm x easting


            ///659052,5571	ok

            Y = eta * v * (1 + chishort) + B; //4677454,987			utm y northing


            ///19840,43253	ok		


        }



    }
}
