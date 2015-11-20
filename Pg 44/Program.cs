using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number one");
            var numberOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number two");
            var numberTwo = Int32.Parse(Console.ReadLine());
            var quotient = numberOne/numberTwo;
            var remainder = numberOne%numberTwo;
            var bonus = numberTwo*quotient + remainder;

            Console.WriteLine(numberOne + "/" + numberTwo + " is " + quotient + " remainder " + remainder);
            Console.WriteLine(numberTwo + " * " + quotient + " + " + remainder + " = " + bonus);

            ShowExit();
        }

        static void ShowExit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
