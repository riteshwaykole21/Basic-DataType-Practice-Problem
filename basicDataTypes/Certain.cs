using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDataTypes
{
    public class Certain
    {
        public void Display()
        {
           
            int x, y;
            for (y = -5; y <=5; y++)
            {
                x = y * y - 2 * y + 1;
                Console.WriteLine(x);
            }
        }

    }
}
