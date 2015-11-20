using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator");
            Console.WriteLine("Enter the first number");
            var numberOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            var numberTwo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter an operation +, -, *, /, %, ^");
            var operation = Console.ReadLine();
            var result = 0;

            switch (operation)
            {
                case "+":
                    result = numberOne + numberTwo;
                    break;
                case "-":
                    result = numberOne - numberTwo;
                    break;
                case "*":
                    result = numberOne * numberTwo;
                    break;
                case "/":
                    result = numberOne / numberTwo;
                    break;
                case "%":
                    result = numberOne % numberTwo;
                    break;
                case "^":
                    result = Int32.Parse(Math.Pow(numberOne, numberTwo).ToString());
                    break;
            }

            Console.WriteLine("Result of " + numberOne + " " + operation + " " + numberTwo + " = " + result);
            ShowExit();
        }

        private static void ShowExit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
