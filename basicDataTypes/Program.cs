using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDataTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 :Enter Three Lettter");
            Console.WriteLine("Enter a Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    Display display = new Display();
                    display.Them();
                    break;
            }
            Console.ReadLine();
        }
    }
}
