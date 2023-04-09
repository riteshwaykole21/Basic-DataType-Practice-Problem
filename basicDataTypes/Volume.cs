using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDataTypes
{
    public class Volume
    {
        public void Display()
        {
            double r;
            double PI = 3.14;
            Console.WriteLine("Radius Of Sphere is");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(4 * PI *(r*r));
            Console.WriteLine(4d/3d * PI * (r *r * r));

        }
    }
}
