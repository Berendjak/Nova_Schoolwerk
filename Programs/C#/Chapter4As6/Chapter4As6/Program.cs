using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4As6
{
    class Program
    {
        static void Main(string[] args)
        {
            string year;
            int now = 2016, age;

            Console.WriteLine("Please enter your year of birthyear:");
            year = Console.ReadLine();

            age = now - int.Parse(year);

            Console.WriteLine("Your age is {0}", age);
            Console.ReadLine();
        }
    }
}
