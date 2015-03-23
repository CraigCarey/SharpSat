using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSat
{
    class Utils
    {
        public static bool CheckLatitude(double latitude)
        {
            bool returnVal = true;

            if (latitude > 90.0 || latitude < -90.0)
            {
                returnVal = false;
            }

            return returnVal;
        }

        public static bool CheckLongitude(double longitude)
        {
            bool returnVal = true;

            if (longitude > 180.0 || longitude < -180.0)
            {
                returnVal = false;
            }

            return returnVal;
        }
    }
}
