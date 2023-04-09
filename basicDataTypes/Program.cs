using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace basicDataTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 :Enter Three Lettter");
            Console.WriteLine("2 : Display Trangular Of Width");
            Console.WriteLine("3 : Enter A Two Number");
            Console.WriteLine("4 : Enter a Radius Of Circle");
            Console.WriteLine("Enter a Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    Display display = new Display();
                    display.Them();
                    break;
                case 2:
                    Sharp sharp = new Sharp();
                    sharp.Using();
                    break;
                case 3:
                    Opration opration = new Opration();
                    opration.Taskes();
                    break;
                case 4:
                    RadiusCircle radiusCircle = new RadiusCircle();
                    radiusCircle.Input();
                    break;

            }
            Console.ReadLine();
        }
    }
}
