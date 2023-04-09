using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDataTypes
{
    public class RadiusCircle
    {
        public void Input()
        {
            Console.WriteLine("Enter The Radius Of Circle");
            double Radius = Convert.ToDouble(Console.ReadLine());
            double PI = 3.14;
            double per_cir ;
            per_cir = 2 * PI * Radius;
            Console.WriteLine("Perimeter Of Circle : {0}" ,per_cir);


        }
    }
}
