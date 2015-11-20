using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the cylinder");
            var height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the radius of the base of the cylinder");
            var radius = Int32.Parse(Console.ReadLine());

            var pi = 3.1415926;
            var volume = pi*Math.Pow(radius, 2)*height;
            var surfaceArea = 2*pi*radius*(radius + height);

            Console.WriteLine("The volume = " + volume);
            Console.WriteLine("The Surface Area = " + surfaceArea);

            ShowExit();
        }

        static void ShowExit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
