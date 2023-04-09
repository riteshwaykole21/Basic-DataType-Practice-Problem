using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace basicDataTypes
{
    public class Sharp
    {
        public void Using()
        {
            Console.WriteLine("Enput A Number :");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Disered Width :");
            int Width = Convert .ToInt32(Console.ReadLine());
            int height = Width;
                for (int row = 0; row < height; row++)
                {
                for (int column = 0; column < Width;column++)
                {
                    Console.Write( Number);
                }
                Console.WriteLine();
                Width--;
                }
        }
    }
}
