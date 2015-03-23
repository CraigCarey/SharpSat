using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSat
{
    class Program
    {
        static void Main(string[] args)
        {
            Dish myDish = new Dish(53.55, -2.77);

            Satellite mySat = new Satellite("TestSat", -27.0);
            mySat.CalcDishAngles(myDish.Latitude, myDish.Longitude);

            Console.WriteLine("Azimuth: {0}, Elevation: {1}", mySat.Azimuth, mySat.Elevation);
        }
    }
}
