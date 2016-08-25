using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            string height, width;

            Console.WriteLine("Please enter the width:");
            width = Console.ReadLine();
            Console.WriteLine("Please enter the height:");
            height = Console.ReadLine();
            double awnser = double.Parse(width) * double.Parse(height);
            Console.WriteLine("The area of rectangle is {0}", awnser);
            Console.ReadLine();
        }
    }
}
