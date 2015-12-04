using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg_43
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base of triangle");
            var triangleBase = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of triangle");
            var triangleHeight = float.Parse(Console.ReadLine());

            var area = .5*triangleBase*triangleHeight;
            Console.WriteLine("Area of triange = " + area);

            ShowExit();
        }

        public static void ShowExit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
