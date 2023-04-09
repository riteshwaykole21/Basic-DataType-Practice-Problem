using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDataTypes
{
    public class Kilometer
    {
        public void Display()
        {
            Console.WriteLine("Enter The Distances");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Houe");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Minute");
            int Z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second");
            int A = Convert.ToInt32(Console.ReadLine());
            double timesec, mps ,kph, mph;
            timesec = (Y*3600) + (Z*60) + A;
            mps = X / timesec;
            kph = (X / 1000.0d) / (timesec / 3600.0d);
            mph = kph / 1.609d;
            Console.WriteLine("Your Speed is Meter Per Second is{0}",mps);
            Console.WriteLine("Your Speed in km/h is {0}", kph);
            Console.WriteLine("Your Speed in Miles/h is {0}",mph);
        }
    }
}
