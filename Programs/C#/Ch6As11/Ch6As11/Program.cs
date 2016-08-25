using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6As11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***MENU***\n\n1. Display Menu 1\n2. Display Menu 2\n3. Exit");
            while (true) {
                ConsoleKeyInfo input = new ConsoleKeyInfo();
                input = Console.ReadKey();
                
                if (input.KeyChar == '1')
                {
                    Console.WriteLine("\bMenu 1");
                    Console.ReadLine();
                }
                else if (input.KeyChar == '2')
                {
                    Console.WriteLine("\bMenu 2");
                    Console.ReadLine();
                }
                else if (input.KeyChar == '3')
                {
                    Console.WriteLine("\bExit");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\bPlease enter 1, 2 or 3:");
                    Console.WriteLine();
                }
            }
        }
    }
}
