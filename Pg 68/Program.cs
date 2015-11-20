using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            var numberOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            var numberTwo = Int32.Parse(Console.ReadLine());

            var message = "";

            if ((numberOne > 0 && numberTwo > 0) || (numberOne < 0 && numberTwo < 0))
            {
                message = "Result is positive";
            }
            else
            {
                message = "Result is negetive";
            }

            Console.WriteLine(message);
            ShowExit();
        }

        private static void ShowExit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
