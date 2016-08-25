using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5As8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is my lucky word?");
            string ans = Console.ReadLine();

            string answer = "lucky";

            Console.WriteLine(ans == answer ? "You typed "+ans.ToUpper()+" and you are correct!" : "You typed " + ans.ToUpper() + " and you are wrong!");
            Console.ReadLine();
        }
    }
}
