using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDataTypes
{
    public class Display
    {
        public void Them()
        {
            char Letter ,Letter1,Letter2;
            Console.WriteLine("Enter A Letter");
            Letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter A Letter");
            Letter1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter A Letter");
            Letter2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0} {1} {2}",Letter2,Letter1,Letter);
        }
    }
}
