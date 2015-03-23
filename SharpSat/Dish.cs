using System;

namespace SharpSat
{
    public class Dish
    {
        public Dish(double dishlatitude, double dishLongitude)
        {
            Latitude = dishlatitude;
            Longitude = dishLongitude;
        }

        private double latitude = 0.0;                
        public double Latitude
        {
            get { return latitude; }
            set
            {
                if (Utils.CheckLatitude(value))
                {
                    latitude = value;
                }
                else
                {
                    Console.WriteLine("Error: Dish latitude out of range (+/- 90.0)");
                    latitude = 0.0;
                }
            }
        }

        private double longitude = 0.0;

        public double Longitude
        {
            get { return longitude; }
            set
            {
                if (Utils.CheckLongitude(value))
                {
                    longitude = value;
                }
                else
                {
                    Console.WriteLine("Error: Dish longitude out of range (+/- 180.0)");
                    longitude = 0.0;
                }
            }
        }
    }
}
