using System;

namespace SharpSat
{
    class Satellite
    {
        public Satellite(string satelliteName, double satelliteLongitude)
        {
            Name = satelliteName;
            Longitude = satelliteLongitude;
        }

        public string Name { get; private set; }
        public double Azimuth { get; private set; }
        public double Elevation { get; private set; }

        private double longitude = 0.0;
        public double Longitude
        {
            get { return longitude; }
            private set
            {
                if (Utils.CheckLongitude(value))
                {
                    longitude = value;
                }
                else
                {
                    Console.WriteLine("Error: Satellite longitude out of range (+/- 180.0)");
                    longitude= 0.0;
                }
            }            
        }

        // Calculates Azimuth and Elevation angles, given dish location
        public void CalcDishAngles(double dishLatitude, double dishLongitude)
        {
            const double Rad = 180 / Math.PI;
            const double InvRad = 1 / Rad;

            double anglePhi = Math.Abs(dishLongitude - Longitude);

            double angleBeta = Math.Acos(Math.Cos(anglePhi * InvRad) * Math.Cos(dishLatitude * InvRad));

            double longDiff = InvRad * (Longitude - dishLongitude);

            double myLatRads = InvRad * dishLatitude;

            double azimuthRaw = (Math.Atan(-Math.Tan(longDiff) / Math.Sin(myLatRads)) * Rad) + 180;

            double azimuthAdj;

            if (dishLatitude > 0)
            {
                azimuthAdj = azimuthRaw;
            } else {
                azimuthAdj = ((180 + azimuthRaw) % 360);
            }

            Azimuth = Math.Round(azimuthAdj, 1);
            Elevation = Rad * Math.Atan((Math.Cos(angleBeta) - (0.151266483)) / Math.Sin(angleBeta));
            Elevation = Math.Round(Elevation, 1);
        }
    }
}
