using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace basicDataTypes
{
    public class Opration
    {
        public void Taskes()
        {
            Console.WriteLine("Enter A First Number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Opration");
            char Y = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int Second = Convert.ToInt32(Console.ReadLine());   
            if (Y == '+')
                Console.WriteLine("{0}+{1}={2}",First,Second,First + Second);
            else if (Y == '-')
                Console.WriteLine("{0}-{1}={2}", First, Second, First - Second);
            else if (Y == '*')
                Console.WriteLine("{0}*{1}={2}", First, Second, First * Second);
            else if (Y == '/')
                Console.WriteLine("{0}/{1}={2}", First, Second, First / Second);
            else
                Console.WriteLine("Wrong Character");
        }
    }
}
