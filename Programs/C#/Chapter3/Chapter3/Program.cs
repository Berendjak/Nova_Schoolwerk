using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            short num = 4;
            if(num >= 1 && num <= 5)
            {
                Console.WriteLine("The number is within range!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The number is out of range!");
                Console.ReadLine();
            }
        }
    }
}
