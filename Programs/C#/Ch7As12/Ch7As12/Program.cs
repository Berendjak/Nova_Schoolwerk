using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7As12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five names");

            string[]  names = new string[6];
            for(int a = 1; a<names.Length; a++)
            {
                Console.WriteLine("Name "+ a +":");
                names[a] = Console.ReadLine();
            }

            for(int b = 1; b < names.Length; b++){
                    Console.Write(names[b] + "\n");
            }
            Console.ReadLine();
        }
    }
}
