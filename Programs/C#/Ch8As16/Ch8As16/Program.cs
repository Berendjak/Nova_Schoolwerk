using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch8As16
{
    class Check
    {
        public int CheckNum(char number)
        {
            char numChar = Convert.ToChar(number);
            if (!Char.IsDigit(numChar))
            {
                WriteLine("Please enter a number");
            }
            else { }
            return number;

        }  
    }
    class Program
    {
        static void Main(string[] args)
        {
            Check Check = new Check();

            WriteLine("Enter first number:");
            char FirstNum = char.Parse(ReadLine());
            Check.CheckNum(FirstNum);
            WriteLine("Enter second number:");
            char SecondNum = char.Parse(ReadLine());
            Check.CheckNum(SecondNum);
        }
    }
}
