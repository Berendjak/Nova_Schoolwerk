using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7As13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five numbers");

            string[] number = new string[6];
            for (int a = 1; a < number.Length; a++)
            {
                Console.WriteLine("Number " + a + ":");
                number[a] = Console.ReadLine();
                char newNum = Convert.ToChar(number[a]);
                if (!Char.IsDigit(newNum))
                {
                    Console.WriteLine("Please enter a number");
                    a--;
                }
                
            }

            for (int b = 1; b < number.Length; b++)
            {
                Console.Write(number[b] + "\n");
            }
            Console.ReadLine();
        }
    }
}
