using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4As7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is mylucky number?");
            ConsoleKeyInfo number = new ConsoleKeyInfo();
            number = Console.ReadKey();

            if (number.KeyChar == '5')
            {
                Console.WriteLine("Correct! My lucky number is 5!");
                Console.ReadLine();
            }else if (Char.IsDigit(number.KeyChar))
            {
                Console.WriteLine("{0} is not a number. Please enter a number!", number.Key);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0} is incorrect!", number.Key);
                Console.ReadLine();
            }
                        
                          

                    
            
        }
    }
}
