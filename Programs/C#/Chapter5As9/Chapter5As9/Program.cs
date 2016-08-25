using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5As9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Drink sizes: 1=small, 2=medium, 3=large.\nPlease enteryour selection: ");
                string input = Console.ReadLine();
                int length = input.Length;


                if (length == 1)
                {
                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("Please insert 25 cents\nThank you! Please come again.");
                            Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine("Please insert 50 cents\nThank you! Please come again.");
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.WriteLine("Please insert 75 cents\nThank you! Please come again.");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Invalid selection! Please enter 1, small, 2, medium, 3 or large");
                            Console.ReadLine();
                            break;

                    }
                }
                else {
                    switch (input)
                    {
                        case "small":
                            Console.WriteLine("Please insert 25 cents\nThank you! Please come again.");
                            Console.ReadLine();
                            break;
                        case "medium":
                            Console.WriteLine("Please insert 50 cents\nThank you! Please come again.");
                            Console.ReadLine();
                            break;
                        case "large":
                            Console.WriteLine("Please insert 75 cents\nThank you! Please come again.");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Invalid selection! Please enter 1, small, 2, medium, 3 or large");
                            Console.ReadLine();
                            break;
                    }
                }
            }
        }
    }
}
