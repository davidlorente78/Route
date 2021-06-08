using Coordinates_One;
using System;

namespace GraphicMap.TravellPlan
{
    [Serializable]
    public class WayPoint
    {

        public UTM UTM;
        public GeographicCoordinate GeographicCoordinate; 
                     
        public string Name;
        public string Identifier;      
        public string Type;
       


        public WayPoint()
        { 
        }

        public WayPoint(UTM UTM, string name)
        {

            this.UTM = UTM;
            GeographicCoordinate = UTM.ConvertToGeographic();
            this.Name = name;
           
       
        }
        public WayPoint(UTM UTM, string Type, string Name, string Identifier)
        {

            this.UTM = UTM;
            GeographicCoordinate = UTM.ConvertToGeographic();
         
            this.Name = Name;
            this.Identifier = Identifier;
            this.Type = Type;
        }

      
        public WayPoint(GeographicCoordinate geographicCoordinate, double Altitude)
        {
            this.GeographicCoordinate = geographicCoordinate;
            this.UTM = geographicCoordinate.ConvertToUTM();           

        }


        public double Latitude
        {

            get { return GeographicCoordinate.LatitudeDegrees; }

        }
        public double Longitude
        {

            get { return GeographicCoordinate.LongitudeDegrees; }
        }

       

        public GeographicCoordinate GeoCoordinate
        {

            get { return GeographicCoordinate; }
            set { GeographicCoordinate = value; }


        }

        public UTM UTMCoordinate
        {
            get { return this.UTM; }
            set { this.UTM = value; }
        }       

        public override bool Equals(object obj)
        {
            WayPoint ToCheck = (WayPoint)obj;
            return (this.Identifier == ToCheck.Identifier);
                        
        }

        public override int GetHashCode()
        {
            //Problems Serializing 
            return Convert.ToInt16(this.GeographicCoordinate.LatitudeSeconds);
        }


    }
}
